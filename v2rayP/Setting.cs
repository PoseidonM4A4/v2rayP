using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2rayP.Model;
using v2rayP.Util;
using static v2rayP.Util.Logging;

namespace v2rayP
{
    public class Setting
    {
        #region Constants
        public const string AppName = "v2rayP";
        public const string AppVersion = "0.1.0";
        public const string SettingFilename = "settings.json";

        // PAC Server 
        public const string PacName = "pac.txt";
        public const string CustomRuleName = "custom-rule.txt";
        public const string GFWListName = "gfwlist.txt";

        // V2Ray Setting
        public static readonly V2RayVersion V2RayMinimumRequiredVersion = new V2RayVersion(3, 0, 0);
        public const string V2RayDirectory = "core";
        public const string V2RayExecutableName = "v2ray.exe";
        public const string V2RayConfigFilename = "config.json";
        public const string V2RayErrorLog = "error.log";
        public const string V2RayAccessLog = "access.log";

        // Logger
        public const string LogName = "v2rayP-{0}.log";
        public const string LogDirectory = "logs";

        // V2Ray Default Setting
        public static readonly string[] VmessSecurity = { "aes-128-cfb", "aes-128-gcm", "chacha20-poly1305", "auto", "none" };
        public static readonly string[] NetworkTypes = { "ws", "tcp", "kcp" };
        public static readonly string[] KCPHeaderTypes = { "none", "srtp", "utp", "wechat-video" };
        public const int KCPDownlinkCapacity = 20;
        public const int KCPUplinkCapacity = 5;
        public const int KCPMtu = 1350;
        public const int KCPTti = 50;
        public const int KCPWriteBufferSize = 2;
        public const int KCPReadBufferSize = 2;
        public const bool KCPCongestion = false;
        public const string KCPHeaderType = "none";
        #endregion

        #region Runtime Settings
        public static bool AutoStart;
        public static ProxyMode Mode;
        public static List<VMess> Servers;
        public static int ActiveServerIndex;
        public static int SocksPort;
        public static int HttpPort;
        public static int PacPort;
        public static bool AcceptLAN;
        public static bool EnableUDP;
        public static bool UpdateViaProxy;
        public static string GFWListURL;
        public static LogLevel LogLevel;
        public static bool EnableAccessLog;
        public static bool EnableErrorLog;

        public static string ListenAddress => AcceptLAN ? "0.0.0.0" : "127.0.0.1";
        public static VMess ActiveServer => (Servers.Count > ActiveServerIndex || ActiveServerIndex < 0) ? Servers[ActiveServerIndex] : null;
        #endregion

        static string configPath;

        static Setting()
        {
            configPath = Path.Combine(Application.StartupPath, SettingFilename);
        }

        public static void Load()
        {
            Model.Setting setting;
            if (!File.Exists(configPath)) setting = new Model.Setting();
            else setting = JSON.Read<Model.Setting>(configPath);
            
            LogLevel = setting.LogLevel;
            AutoStart = setting.AutoStart;
            Mode = setting.Mode;
            SocksPort = setting.SockPort;
            PacPort = setting.PacPort;
            HttpPort = setting.HttpPort;
            AcceptLAN = setting.AcceptLAN;
            Servers = setting.Servers as List<VMess>;
            ActiveServerIndex = setting.Active;
            EnableUDP = setting.EnableUDP;
            GFWListURL = setting.GFWListURL;
            UpdateViaProxy = setting.UpdateViaProxy;
            EnableAccessLog = setting.EnableAccessLog;
            EnableErrorLog = setting.EnableErrorLog;

            if (ActiveServerIndex >= Servers.Count || ActiveServerIndex < 0)
            {
                ActiveServerIndex = 0;
            }
        }

        public static void Save()
        {
            var settings = new Model.Setting
            {
                LogLevel = LogLevel,
                AutoStart = AutoStart,
                Mode = Mode,
                SockPort = SocksPort,
                PacPort = PacPort,
                HttpPort = HttpPort,
                AcceptLAN = AcceptLAN,
                Servers = Servers,
                Active = ActiveServerIndex,
                EnableUDP = EnableUDP,
                GFWListURL = GFWListURL,
                UpdateViaProxy = UpdateViaProxy,
                EnableErrorLog = EnableErrorLog,
                EnableAccessLog = EnableAccessLog,
            };
            JSON.Write(configPath, settings);
        }
    }
}
