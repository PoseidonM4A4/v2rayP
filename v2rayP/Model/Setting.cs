using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static v2rayP.Util.Logging;

namespace v2rayP.Model
{
    public enum ProxyMode
    {
        KeepSystemProxy = 0,
        Disable,
        Global,
        PAC
    }

    /// <summary>
    /// v2rayP settings
    /// </summary>
    [Serializable]
    public class Setting
    {
        /// <summary>
        /// Automatically starts with Windows
        /// </summary>
        public bool AutoStart { set; get; } = false;

        /// <summary>
        /// Log level of V2Ray and v2rayP
        /// </summary>
        public LogLevel LogLevel { set; get; } = LogLevel.Warning;

        /// <summary>
        /// Enable v2ray core access log
        /// </summary>
        public bool EnableAccessLog { set; get; } = true;

        /// <summary>
        /// Enable v2ray core error log
        /// </summary>
        public bool EnableErrorLog { set; get; } = false;

        /// <summary>
        /// Proxy Mode
        /// </summary>
        public ProxyMode Mode { set; get; } = ProxyMode.KeepSystemProxy;

        /// <summary>
        /// SOCK5 Proxy Port
        /// </summary>
        public int SockPort { set; get; } = 10080;

        /// <summary>
        /// HTTP Proxy Port
        /// </summary>
        public int HttpPort { set; get; } = 1080;

        /// <summary>
        /// PAC Server Port
        /// </summary>
        public int PacPort { set; get; } = 10081;

        /// <summary>
        /// Accpet connections from LAN devices
        /// </summary>
        public bool AcceptLAN { set; get; } = true;

        /// <summary>
        /// Decide whether SOCKS5 proxy server will accpet UDP connections
        /// </summary>
        public bool EnableUDP { set; get; } = true;

        /// <summary>
        /// Update via proxy. GFWList, v2rayP, v2ray-core...
        /// </summary>
        public bool UpdateViaProxy { set; get; } = true;

        /// <summary>
        /// GFWList URL, this list should be encoded in Base64
        /// </summary>
        public string GFWListURL { set; get; } = "https://raw.githubusercontent.com/gfwlist/gfwlist/master/gfwlist.txt";

        /// <summary>
        /// Active server index
        /// </summary>
        public int Active { set; get; } = 0;

        /// <summary>
        /// V2Ray server configurations
        /// </summary>
        public IList<VMess> Servers { set; get; } = new List<VMess>();
    }
}
