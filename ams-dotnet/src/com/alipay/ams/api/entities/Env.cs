

namespace com.alipay.ams.api.entities
{
    public class Env
    {
        public Env()
        {
        }


        public string StoreTerminalId { get; internal set; }


        public string StoreTerminalRequestTime { get; internal set; }

        public TerminalType TerminalType { get; set; }

        public string UserAgent { get; set; }

        public OsType OsType { get; set; }


        public string DeviceTokenId { get; set; }


        public string ClientIp { get; set; }


        public string CookieId { get; set; }


        public string ExtendInfo { get; set; }
    }
}
