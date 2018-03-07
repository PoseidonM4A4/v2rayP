using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using v2rayP.Model;
using v2rayP.Resources.Localization;
using v2rayP.Util;
using static v2rayP.Util.Logging;

namespace v2rayP.Manager
{
    public class V2RayManager
    {
        public bool Running = false;

        public string ConfigName = "config.json";
        public string Directory = "";
        public string ExecutableName = "v2ray.exe";

        public string AccessLog = null;
        public string ErrorLog = null;
        public string ListenAddress;
        public int HttpPort;
        public int SocksPort;
        public bool EnableUdp;
        public LogLevel LogLevel;

        private string directory => Path.Combine(Application.StartupPath, Directory);
        private string executablePath => Path.Combine(Application.StartupPath, Directory, ExecutableName);
        private string configPath => Path.Combine(Application.StartupPath, Directory, ConfigName);
        private string accessLog => Path.Combine(Application.StartupPath, Directory, AccessLog);
        private string errorLog => Path.Combine(Application.StartupPath, Directory, ErrorLog);

        private V2RayVersion MinimumRequriedVersion;
        private Process process;
        private Thread RedirectErrorLogThread;
        private Thread RedirectAccessLogThread;
        private Thread DetectV2RayAliveThread;

        public V2RayManager(V2RayVersion minimumRequriedVersion)
        {
            MinimumRequriedVersion = minimumRequriedVersion;
        }

        public bool WriteConfig(VMess server)
        {
            var streamSettings = server?.StreamSettings;
            if (streamSettings?.TlsSettings != null && string.IsNullOrWhiteSpace(streamSettings?.TlsSettings.ServerName))
            {

                streamSettings = new StreamSetting()
                {
                    Network = server.StreamSettings.Network,
                    Security = server.StreamSettings.Security,
                    WsSettings = server.StreamSettings.WsSettings,
                    TcpSettings = server.StreamSettings.TcpSettings,
                    KcpSettings = server.StreamSettings.KcpSettings,
                };

                streamSettings.TlsSettings = new TLSSetting()
                {
                    ServerName = null,
                    AllowInsecure = server.StreamSettings.TlsSettings.AllowInsecure,
                };
            }

            var dns = new { servers = new string[] { "8.8.8.8", "8.8.4.4", } };

            var log = new
            {
                error = ErrorLog == null ? null : errorLog,
                access = AccessLog == null ? null : accessLog,
                loglevel = LogLevel.ToString().ToLower(),
            };

            var inbound = new
            {
                protocol = "socks",
                port = SocksPort,
                listen = ListenAddress,
                settings = new
                {
                    auth = "noauth",
                    udp = EnableUdp,
                    ip = ListenAddress,
                    timeout = 300
                }
            };

            var inboundDetour = new object[]
            {
                new {
                    protocol = "http",
                    port = HttpPort,
                    listen = ListenAddress,
                    settings = new { timeout = 0 },
                }
            };

            var outbound = new
            {
                tag = "tag_proxy",
                protocol = "vmess",
                mux = new
                {
                    enable = server.EnableMux,
                },
                settings = new
                {
                    vnext = new[] 
                    {
                        new {
                            address = server?.Address,
                            port = server?.Port,
                            users = new []
                            {
                                new {
                                    id = server?.UserId,
                                    alterId = server?.AlterId,
                                    security = server?.Security,
                                }
                            }
                        }
                    }
                },
                streamSettings = streamSettings,
            };

            var outboundDetour = new object[]
            {
                new
                {
                    tag = "tag_block",
                    protocol = "blackhole",
                    settings = new { response = new { type = "http" } },

                },
                new
                {
                    tag = "tag_direct",
                    protocol = "freedom",
                    settings = new { tiemout = 0 },
                }
            };

            var routing = new
            {
                strategy = "rules",
                settings = new
                {
                    domainStrategy = "IPIfNonMatch",
                    rules = new[]
                    {
                        new
                        {
                            type = "field",
                            outboundTag = "tag_direct",
                            ip = new string[]
                            {
                                "0.0.0.0/8",
                                "10.0.0.0/8",
                                "100.64.0.0/10",
                                "127.0.0.0/8",
                                "169.254.0.0/16",
                                "172.16.0.0/12",
                                "192.0.0.0/24",
                                "192.0.2.0/24",
                                "192.168.0.0/16",
                                "198.18.0.0/15",
                                "198.51.100.0/24",
                                "203.0.113.0/24",
                                "::1/128",
                                "fc00::/7",
                                "fe80::/10",
                            },
                        },
                    },
                },
            };

            var config = new { log, inbound, inboundDetour, outbound, outboundDetour, routing };

            return JSON.Write(configPath, config);
        }

        public void Start()
        {
            FileHelper.TouchDirectory(directory);

            Stop();

            if (!V2RayExists(executablePath))
            {
                MsgBox.Error(string.Format(I18n.MsgV2RayFailedToStartDueToInexistence, directory));
                return;
            }

            if (!CheckVersionRequirement())
            {
                MsgBox.Error(string.Format(I18n.MsgV2RayIsTooOld, MinimumRequriedVersion.ToString()));
                return;
            }

            process = new Process
            {
                StartInfo = {
                    FileName = executablePath,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    WorkingDirectory = directory,
                }
            };

            process.Exited += Process_Exited;
            process.OutputDataReceived += (sender, args) =>
            {
                var log = FormatV2RayLog(args.Data);
                if (!string.IsNullOrWhiteSpace(log)) Logging.Info(log, "v2ray-core");
            };
            process.ErrorDataReceived += (sender, args) =>
            {
                var log = FormatV2RayLog(args.Data);
                if (!string.IsNullOrWhiteSpace(log)) Logging.Error(log, "v2ray-core");
            };
            process.Start();
            Running = true;

            DetectV2RayAliveThread = new Thread(new ThreadStart(() =>
            {
                Thread.Sleep(10000);
                if (process.HasExited) MsgBox.Error(I18n.MsgV2RayFailedToStart);
            }));

            process.BeginOutputReadLine();
            Program.Job.AddProcess(process.Handle);
        }

        public void RestartRedirectV2RayLog(bool access, bool error)
        {
            FileHelper.TouchDirectory(directory);

            if (!error && RedirectErrorLogThread != null && RedirectErrorLogThread.IsAlive)
            {
                RedirectErrorLogThread.Abort();
                RedirectErrorLogThread = null;
            }

            if (!access && RedirectAccessLogThread != null && RedirectAccessLogThread.IsAlive)
            {
                RedirectAccessLogThread.Abort();
                RedirectAccessLogThread = null;
            }

            DeleteV2RayLog();

            if (error && RedirectErrorLogThread == null)
            {
                var parameters = new string[] { ErrorLog, "v2ray-error", "error" };
                RedirectErrorLogThread = new Thread(new ParameterizedThreadStart(RedirectV2RayLogWorker));
                RedirectErrorLogThread.Start(parameters);
            }

            if (access && RedirectAccessLogThread == null)
            {
                var parameters = new string[] { accessLog, "v2ray-access", "access" };
                RedirectAccessLogThread = new Thread(new ParameterizedThreadStart(RedirectV2RayLogWorker));
                RedirectAccessLogThread.Start(parameters);
            }
        }

        public void Stop()
        {
            if (DetectV2RayAliveThread != null && !DetectV2RayAliveThread.IsAlive) DetectV2RayAliveThread = null;

            if (DetectV2RayAliveThread != null)
            {
                DetectV2RayAliveThread.Abort();
                DetectV2RayAliveThread = null;
            }

            if (process != null && process.HasExited) process = null;

            if (process != null)
            {
                process.Kill();
                process.Close();
                process = null;
            }

            DeleteV2RayLog();
        }

        public void OnExit()
        {
            Stop();
            if (RedirectErrorLogThread != null) RedirectErrorLogThread.Abort();
            if (RedirectAccessLogThread != null) RedirectAccessLogThread.Abort();
        }

        public bool CheckVersionRequirement()
        {
            var currentVersion = GetV2RayVersion();
            return currentVersion >= MinimumRequriedVersion;
        }

        public void DeleteV2RayLog()
        {
            try
            {
                if (AccessLog != null) File.Delete(accessLog);
                if (ErrorLog != null) File.Delete(errorLog);
            }
            catch { }
        }

        public static string FormatV2RayLog(string rawLog)
        {
            // V2Ray produce log like this
            // 2017/11/13 16:27:09 [Debug]App|Proxyman|Inbound: creating tcp worker on 192.168.1.6:10080
            // I want it to be
            // App|Proxyman|Inbound: creating tcp worker on 192.168.1.6:10080

            if (rawLog == null) return null;

            // Although the regular expression is not 100% precise to match a time string, but still works.
            var reg = new Regex(@"^[0-9]{4}\/[0-9]{2}\/[0-9]{2}\s[0-9]{2}:[0-9]{2}:[0-9]{2}\s\[[a-zA-Z]{0,}\]");
            return reg.Replace(rawLog, "");
        }

        public static string FormatV2RayAccessLog(string rawLog)
        {
            // V2Ray produce log like this
            // 2017/11/13 16:27:09 127.0.0.1:54987 accepted //www.google.com.hk:443 
            // I want it to be
            // 127.0.0.1:54987 accepted //www.google.com.hk:443 

            if (rawLog == null) return null;

            // Although the regular expression is not 100% precise to match a time string, but still works.
            var reg = new Regex(@"^[0-9]{4}\/[0-9]{2}\/[0-9]{2}\s[0-9]{2}:[0-9]{2}:[0-9]{2}\s");
            return reg.Replace(rawLog, "");
        }

        public static bool V2RayExists(string path) => File.Exists(path);

        private void Process_Exited(object sender, EventArgs e)
        {
            Running = false;
        }

        private void RedirectV2RayLogWorker(object data)
        {
            var parameters = data as string[];
            var logFilename = parameters[0];
            var logger = parameters[1];
            var type = parameters[2];
            var logPath = Path.Combine(directory, logFilename);

            var wh = new AutoResetEvent(true);
            var fsw = new FileSystemWatcher(directory)
            {
                Filter = logFilename,
                EnableRaisingEvents = true
            };
            fsw.Changed += (s, e) => wh.Set();

            while (!File.Exists(logPath)) Thread.Sleep(1000);
            var fs = new FileStream(logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (var sr = new StreamReader(fs))
            {
                var s = "";
                while (true)
                {
                    s = sr.ReadLine();
                    if (s != null)
                    {
                        var log = type == "error" ? FormatV2RayLog(s) : FormatV2RayAccessLog(s);
                        if (!string.IsNullOrWhiteSpace(log)) Logging.Info(log, logger);
                    }
                    else wh.WaitOne(1000);
                }
            }
        }

        #region Core Updator
        public V2RayVersion GetV2RayVersion()
        {
            var process = new Process();
            process.StartInfo.FileName = executablePath;
            process.StartInfo.Arguments = "-version";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;

            var stdout = string.Empty;
            process.OutputDataReceived += (s, e) => stdout += e.Data;

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit(3000);

            if (!process.HasExited) process.Kill();

            var regex = new Regex(@"^V2Ray\sv(\d+).(\d+)(?:.(\d+))?");
            var match = regex.Match(stdout);

            try
            {
                if (!match.Success) throw new Exception();
                var version = new V2RayVersion
                {
                    Major = Convert.ToInt32(match.Groups[1].ToString()),
                    Minor = Convert.ToInt32(match.Groups[2].ToString()),
                    Build = Convert.ToInt32(string.IsNullOrWhiteSpace(match.Groups[3].ToString()) ? "0" : match.Groups[3].ToString()),
                };
                return version;
            }
            catch
            {
                Logging.Error("Cannot dectect v2ray-core version, \r\n" +
                    $"  Command: {executablePath} -version\r\n" +
                    $"  Output: {stdout}", "v2ray-updator");
                return null;
            }
        }

        string GetLatestReleaseInfo(WebProxy proxy = null)
        {
            var url = "https://api.github.com/repos/v2ray/v2ray-core/releases/latest";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = $"{Setting.AppName}/${Setting.AppVersion}";
            if (proxy != null) request.Proxy = proxy;

            var UTF8 = new UTF8Encoding(false);
            using (var response = request.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }

        public V2RayVersion GetLatestV2RayVersion(string releaseInfo)
        {
            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(releaseInfo);
            var versionTag = json["tag_name"].ToString();

            var regex = new Regex(@"^v(\d+).(\d+?)(?:.(\d+))?$");
            var match = regex.Match(versionTag);

            try
            {
                if (!match.Success) throw new Exception();
                var version = new V2RayVersion
                {
                    Major = Convert.ToInt32(match.Groups[1].ToString()),
                    Minor = Convert.ToInt32(match.Groups[2].ToString()),
                    Build = Convert.ToInt32(string.IsNullOrWhiteSpace(match.Groups[3].ToString()) ? "0" : match.Groups[3].ToString()),
                };
                return version;
            }
            catch
            {
                Logging.Error("Cannot get latest v2ray version from GitHub, \r\n" +
                    $"  CONTENT: {releaseInfo}\r\n" +
                    $"  TAG: {versionTag}",
                    "v2ray-updator");
                return null;
            }
        }

        public V2RayVersion GetLatestV2RayVersion(WebProxy proxy = null) => GetLatestV2RayVersion(GetLatestReleaseInfo(proxy));

        public bool UpdateV2Ray(WebProxy proxy = null)
        {
            // get asset url
            var releaseInfo = GetLatestReleaseInfo(proxy);
            var releaseJSON = JsonConvert.DeserializeObject<Dictionary<string, object>>(releaseInfo);

            var assets = releaseJSON["assets"] as Dictionary<string, object>[];
            var assetName = Environment.Is64BitOperatingSystem ? "v2ray-windows-64.zip" : "v2ray-windows-32.zip";
            string assetURL = null;

            foreach (var asset in assets)
            {
                if (asset["name"].ToString() == assetName)
                {
                    assetURL = asset["browser_download_url"].ToString();
                    break;
                }
            }

            if (assetURL == null)
            {
                Logging.Error($"Cannot match GitHub release asset \"{assetName}\"", "v2ray-updator");
                return false;
            }

            var tempPath = Path.Combine(Path.GetTempPath(), assetName);
            DownLoadV2Ray(assetURL, tempPath, proxy);

            File.Delete(tempPath);
            return true;
        }

        public void DownLoadV2Ray(string assetURL, string path, WebProxy proxy = null)
        {
            FileHelper.TouchDirectory(Path.GetDirectoryName(path));
            if (File.Exists(path)) File.Delete(path);

            var request = WebRequest.Create(assetURL) as HttpWebRequest;
            request.UserAgent = $"{Setting.AppName}/${Setting.AppVersion}";
            if (proxy != null) request.Proxy = proxy;
            var response = request.GetResponse();

            using (var stream = response.GetResponseStream()) UncompressV2Ray(stream, path);
        }

        public static void UncompressV2Ray(Stream stream, string destination)
        {
            var buffer = new byte[4096];
            using (ZipArchive archive = new ZipArchive(stream))
            {
                var folder = archive.Entries[0].FullName;
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.Equals(archive.Entries[0])) continue;

                    var fullPath = Path.Combine(destination, entry.FullName.Substring(folder.Length));
                    var fullDirecotry = Path.GetDirectoryName(fullPath);

                    FileHelper.TouchDirectory(fullDirecotry);

                    if (entry.FullName.EndsWith("/") || entry.FullName.EndsWith("\\")) continue;

                    using (var fileStream = File.Open(fullPath, FileMode.Create))
                    using (var zipStream = entry.Open())
                    {
                        while (true)
                        {
                            var size = zipStream.Read(buffer, 0, buffer.Length);
                            if (size <= 0) break;
                            fileStream.Write(buffer, 0, size);
                        }

                    }
                }
            }
        }
        #endregion
    }
}
