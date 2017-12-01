using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2rayP.Manager;
using v2rayP.Model;
using v2rayP.Resources.Localization;
using v2rayP.UI;
using v2rayP.Util;

namespace v2rayP
{
    static class Launcher
    {
        public static TrayIcon NotifyIcon = new TrayIcon();
        public static V2RayManager V2Ray = new V2RayManager(Setting.V2RayMinimumRequiredVersion);
        public static PacManager Pac = new PacManager();

        static Launcher()
        {
            V2Ray.Directory = Setting.V2RayDirectory;
            V2Ray.ExecutableName = Setting.V2RayExecutableName;
        }

        public static void Start()
        {
            Logging.Start();
            Logging.Info($"{Setting.AppName} {Setting.AppVersion}");

            Setting.Load();

            NotifyIcon.Create();
            NotifyIcon.UpdateServers();

            if (Setting.Servers.Count > 0)
            {
                SwitchProxyMode(Setting.Mode);
                ActivateServer(Setting.ActiveServerIndex);
            }
            else
            {
                NotifyIcon.ShowEditServersForm();
            }

            Application.Run();
        }

        public static void StartPACServer()
        {
            Pac.Stop();
            Pac.HttpPort = Setting.HttpPort;
            Pac.Port = Setting.PacPort;
            Pac.CustomRuleName = Setting.CustomRuleName;
            Pac.GFWListName = Setting.GFWListName;
            Pac.PacName = Setting.PacName;
            Pac.Start();
        }

        public static void Stop()
        {
            V2Ray.OnExit();
            Pac.OnExit();

            SystemProxy.Disable();
            Application.Exit();
        }

        public static void SwitchProxyMode(ProxyMode mode)
        {
            switch (mode)
            {
                case ProxyMode.Global:
                    SystemProxy.EnableGlobal($"http://127.0.0.1:{Setting.HttpPort}");
                    break;
                case ProxyMode.PAC:
                    SystemProxy.EnablePac(Pac.PacScriptURL);
                    break;
                case ProxyMode.Disable:
                    SystemProxy.Disable();
                    break;
                case ProxyMode.KeepSystemProxy:
                default:
                    break;
            }
            NotifyIcon.SwitchProxyMode(mode);
            Setting.Mode = mode;
            Setting.Save();
        }

        public static void UpdateServers(List<VMess> servers)
        {
            Setting.Servers = servers;
            NotifyIcon.UpdateServers();
        }

        public static void ActivateServer(int index)
        {
            if (index >= Setting.Servers.Count || index < 0) index = 0;

            Setting.ActiveServerIndex = index;
            V2Ray.LogLevel = Setting.LogLevel;
            V2Ray.ListenAddress = Setting.ListenAddress;
            V2Ray.HttpPort = Setting.HttpPort;
            V2Ray.SocksPort = Setting.SocksPort;
            V2Ray.EnableUdp = Setting.EnableUDP;
            V2Ray.AccessLog = Setting.EnableAccessLog ? Setting.V2RayAccessLog : null;
            V2Ray.ErrorLog = Setting.EnableErrorLog ? Setting.V2RayErrorLog : null;
            V2Ray.WriteConfig(Setting.ActiveServer);

            V2Ray.RestartRedirectV2RayLog(Setting.EnableAccessLog, Setting.EnableErrorLog);
            V2Ray.Start();
            Setting.Save();
        }

        public static void GetGFWList(string url)
        {
            var canProxy = V2Ray.Running && Setting.UpdateViaProxy;
            var proxy = canProxy ? GetProxy() : null;
            if (!canProxy) NotifyIcon.ShowBalloonTip(I18n.MsgFallbackToDirectUpdateGFWList, ToolTipIcon.Info);

            Pac.GetGFWList(url, proxy);
        }

        public static WebProxy GetProxy() => new WebProxy("127.0.0.1", Setting.HttpPort);
    }
}
