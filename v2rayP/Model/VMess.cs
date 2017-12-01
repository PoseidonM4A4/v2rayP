using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using v2rayP.Resources.Localization;

namespace v2rayP.Model
{
    [Serializable]
    public class VMess : BaseModel
    {
        [NonSerialized]
        public Guid Id = new Guid();

        /// <summary>
        /// Remark of the server
        /// </summary>
        public string Remark;

        /// <summary>
        /// Address to the server. Could be a domain name or a IP
        /// </summary>
        public string Address = "v2ray.cool";

        /// <summary>
        /// Service Port.
        /// </summary>
        public int Port = 10086;

        /// <summary>
        /// User ID
        /// </summary>
        public string UserId = "a3482e88-686a-4a58-8126-99c9df64b7bf";

        /// <summary>
        /// User AlterID
        /// </summary>
        public int AlterId = 64;

        /// <summary>
        /// Encryption Method
        /// </summary>
        public string Security = "auto";

        /// <summary>
        /// Enable Mux
        /// </summary>
        public bool EnableMux = true;

        /// <summary>
        /// Stream Setting. About Data Transportation.
        /// </summary>
        public StreamSetting StreamSettings = null;

        public override string ToString()
        {
            var label = string.Empty;
            if (string.IsNullOrWhiteSpace(Address))
            {
                var transport = string.Empty;
                switch (StreamSettings?.Network)
                {
                    case "kcp": transport = "[mKCP]"; break;
                    case "ws": transport = "[WebSocket]"; break;
                    case "tcp":
                    default: transport = "[TCP]"; break;
                }

                var tls = StreamSettings?.Security == "tls" ? "[TLS]" : string.Empty;
                label = $"{transport}{tls}{Address}:{Port}";
            }
            else if (!string.IsNullOrWhiteSpace(Remark)) {
                label = Remark;
            }
            else
            {
                label = I18n.NewV2RayServer;
            }

            return label;
        }
    }

    [Serializable]
    public class StreamSetting : BaseModel
    {

        /// <summary>
        /// Network Type
        /// Possible Value: tcp, kcp, ws
        /// </summary>
        public string Network = "tcp";

        /// <summary>
        /// Enable TLS
        /// Possible Value: none, tls
        /// </summary>
        public string Security = "none";

        /// <summary>
        /// TLS Settings
        /// </summary>
        public TLSSetting TlsSettings = null;

        public TCPSetting TcpSettings = null;
        public KCPSetting KcpSettings = null;
        public WebSocketSetting WsSettings = null;
    }

    [Serializable]
    public class TLSSetting : BaseModel
    {
        public string ServerName;
        public bool AllowInsecure = false;
    }

    [Serializable]
    public class TCPSetting : BaseModel
    {
        public TCPHeaderSetting Header = new TCPHeaderSetting();
    }

    [Serializable]
    public class TCPHeaderSetting : BaseModel
    {
        public string Type = "none";
        public TCPHTTPRequest Request = new TCPHTTPRequest();
        public TCPHTTPResponse Response = new TCPHTTPResponse();
    }

    [Serializable]
    public class TCPHTTPRequest : BaseModel
    {
        public string Version = "1.1";
        public string Method = "GET";
        public object Path = "/";
        public Dictionary<string, object> Headers;
    }

    [Serializable]
    public class TCPHTTPResponse : BaseModel
    {
        public string Version = "1.1";
        public string Status = "200";
        public string Reason = "OK";
        public Dictionary<string, object> Headers;
    }

    [Serializable]
    public class KCPSetting : BaseModel
    {
        public KCPHeaderSetting Header = new KCPHeaderSetting();
        
        public int Mtu = 1350;
        public int Tti = 50;
        public int UplinkCapacity = 20;
        public int DownlinkCapacity = 5;
        public int ReadBufferSize = 2;
        public int WriteBufferSize = 2;
        public bool Congestion = false;
    }

    [Serializable]
    public class KCPHeaderSetting : BaseModel
    {
        public string Type = "none";
    }

    [Serializable]
    public class WebSocketSetting : BaseModel
    {
        public string Path = "";
        public Dictionary<string, object> Headers;
    }
}
