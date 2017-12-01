using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2rayP.Resources.Localization;
using v2rayP.Util;

namespace v2rayP.Manager
{
    public class PacManager
    { 
        static Random random = new Random();

        public string PacName = "pac.txt";
        public string CustomRuleName = "custom-rule.txt";
        public string GFWListName = "gfwlist.txt";

        public string PacPath => Path.Combine(Application.StartupPath, PacName);
        public string CustomRulePath => Path.Combine(Application.StartupPath, CustomRuleName);
        public string GFWListPath => Path.Combine(Application.StartupPath, GFWListName);

        public int Port;
        public int HttpPort;

        public string PacScriptURL => $"http://127.0.0.1:{Port}/pac.js?=t{random.Next()}";
        public string PacScript = String.Empty;

        Thread ThreadPacServer;
        FileSystemWatcher PacFileWatcher;
        HttpListener PacListener;
        
        public void Start()
        {
            Stop();

            FileHelper.TouchFile(PacPath);
            PacScript = File.ReadAllText(PacPath);

            ThreadPacServer = new Thread(new ThreadStart(PacServerThreadWorker));
            ThreadPacServer.Start();

            PacFileWatcher = new FileSystemWatcher(Application.StartupPath)
            {
                Filter = CustomRuleName,
                EnableRaisingEvents = true,
            };

            FileSystemEventHandler handler = (s, e) => UpdatePacFile();

            PacFileWatcher.Changed += new FileSystemEventHandler(handler);
            PacFileWatcher.Created += new FileSystemEventHandler(handler);
            PacFileWatcher.Deleted += new FileSystemEventHandler(handler);
            PacFileWatcher.Renamed += new RenamedEventHandler(handler);
        }

        public void Stop()
        {
            if (PacListener != null)
            {
                PacListener.Abort();
                PacListener = null;
            }

            if (ThreadPacServer != null)
            {
                ThreadPacServer.Abort();
                ThreadPacServer = null;
            }

            if (PacFileWatcher != null)
            {
                PacFileWatcher.Dispose();
                PacFileWatcher = null;
            }
        }

        public void OnExit()
        {
            Stop();
        }

        public void GetGFWList(string url, WebProxy proxy = null)
        {
            var thread = new Thread(new ThreadStart(() =>
            {
                var UTF8 = new UTF8Encoding(false);
                try
                {
                    var request = WebRequest.Create(url);
                    if (proxy != null) request.Proxy = proxy;

                    request.Method = "GET";

                    var response = request.GetResponse();

                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        var raw = reader.ReadToEnd();
                        var content = UTF8.GetString(Convert.FromBase64String(raw));

                        File.WriteAllText(GFWListPath, content);
                    }

                    UpdatePacFile();

                    Launcher.NotifyIcon.ShowBalloonTip(I18n.UpdateGFWListSuccess, ToolTipIcon.Info);
                    Logging.Debug("GFWList updated.", "PAC");
                }
                catch (Exception ex)
                {
                    Launcher.NotifyIcon.ShowBalloonTip(I18n.UpdateGFWListFailed, ToolTipIcon.Error);
                    Logging.Exception(ex, "PAC");
                }
            }));

            thread.Start();
        }

        public string[] ParseGFWList(string[] lines)
        {
            return lines
                .Where(line => !(line.StartsWith("[") || line.StartsWith("!")) && !string.IsNullOrWhiteSpace(line))
                .ToArray();
        }

        public void UpdatePacFile()
        {
            string[] gfwlist;
            string[] customRule;

            try { gfwlist = ParseGFWList(File.ReadAllLines(GFWListPath)); }
            catch { gfwlist = new string[0]; }

            try { customRule = File.ReadAllLines(CustomRulePath); }
            catch { customRule = new string[0]; }

            var pacRules = gfwlist.Concat(customRule);
            var pacTemplate = FileHelper.GzipDecompressToString(Properties.Resources.pac_template_js);

            PacScript = pacTemplate
                .Replace("__PROXY__", $"PROXY 127.0.0.1:{HttpPort}")
                .Replace("__RULES__", JsonConvert.SerializeObject(pacRules));

            File.WriteAllText(PacPath, PacScript);
        }

        private void PacServerThreadWorker()
        {
            PacListener.Start();

            Logging.Debug("PAC Server Starts", "PAC");
            try
            {
                while (true)
                {
                    var context = PacListener.GetContext();
                    var request = context.Request;
                    var response = context.Response;

                    response.ContentLength64 = Encoding.UTF8.GetByteCount(PacScript);
                    response.ContentType = "application/x-ns-proxy-autoconfig; charset=UTF-8";

                    using (var writer = new StreamWriter(response.OutputStream)) writer.Write(PacScript);
                }
            }
            catch (HttpListenerException ex)
            {
                // listener is stopped 
                if (ex.NativeErrorCode == 995) return;
                else throw;
            }
        }
    }
}
