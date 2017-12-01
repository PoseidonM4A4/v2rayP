using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2rayP.Resources.Localization;
using v2rayP.Util;

namespace v2rayP.Manager
{
    public class PrivoxyManager
    {
        public string ConfigFilename = "v2rayP_http.conf";
        public string AppName = "v2rayP_http";
        public string Directory = null;

        public string directory => Path.Combine(Application.StartupPath, Directory);
        public string executablePath => Path.Combine(Application.StartupPath, Directory, AppName + ".exe");

        public int SocksPort;
        public int HttpPort;
        public string HttpHost;

        Process process;

        public PrivoxyManager()
        {
            Stop();

            if (!FileHelper.TouchDirectory(directory))
            {
                MsgBox.Error(string.Format(I18n.MsgFailToCreateDirectoryFor, "Privoxy", directory));
                Launcher.Stop();
            }

            if (!ExtractPrivoxyFiles())
            {
                MsgBox.Error(I18n.MsgFailToExtractPrivoxy);
                Launcher.Stop();
            }
        }

        ~PrivoxyManager()
        {
            Stop();
        }

        public bool ExtractPrivoxyFiles()
        {
            try
            {
                FileHelper.GzipDecompress(Properties.Resources.mgwz_dll, Path.Combine(directory, "mgwz.dll"));
                FileHelper.GzipDecompress(Properties.Resources.privoxy_exe, Path.Combine(directory, AppName + ".exe"));
            }
            catch (Exception ex)
            {
                Logging.Exception(ex, "Privoxy");
                return false;
            }
            return true;
        }

        public void WriteConfig()
        {
            var configPath = Path.Combine(Application.StartupPath, directory, ConfigFilename);
            var config = String.Join(Environment.NewLine,
                $"listen-address {HttpHost}:{HttpPort}",
                $"show-on-task-bar 0",
                $"activity-animation 0",
                $"forward-socks5 / 127.0.0.1:{SocksPort} .",
                $"hide-console",
                $""
            );
            File.WriteAllText(configPath, config);
        }

        public void Start()
        {
            Stop();

            WriteConfig();

            process = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    FileName = executablePath,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = ConfigFilename,
                    UseShellExecute = true,
                    WorkingDirectory = directory,
                    CreateNoWindow = true,
                }
            };
            process.Start();

            Program.Job.AddProcess(process.Handle);
        }

        public void Stop()
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
                process = null;
            }
        }
    }
}
