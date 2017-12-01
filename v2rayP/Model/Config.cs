using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v2rayP.Model;

namespace v2rayP.Util
{
    /// <summary>
    /// The config of this GUI program.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Automatically starts with the computer
        /// </summary>
        public bool autorun = false;

        /// <summary>
        /// Decide if the proxy service listens to 0.0.0.0
        /// </summary>
        public bool acceptLAN = false;
        
        /// <summary>
        /// Socks Proxy Port
        /// </summary>
        public int socksPort = 10080;

        /// <summary>
        /// HTTP Proxy Port
        /// </summary>
        public int httpPort = 1080;

        /// <summary>
        /// Username for HTTP Proxy Authentication
        /// </summary>
        public string httpUsername = "";

        /// <summary>
        /// Password for HTTP Proxy Authentication
        /// </summary>
        public string httpPassword = "";

        /// <summary>
        /// V2Ray Server Nodes
        /// </summary>
        public VMess[] servers;
    }
}
