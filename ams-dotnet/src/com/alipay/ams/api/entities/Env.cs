

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
        
        public BrowserInfo BrowserInfo  { get; set; }
        public string ColorDepth  { get; set; }
        public string ScreenHeight  { get; set; }
        public string ScreenWidth  { get; set; }
        public int TimeZoneOffset  { get; set; }
        public string DeviceBrand  { get; set; }
        public string DeviceModel  { get; set; }
        public string DeviceLanguage  { get; set; }
        public string DeviceId  { get; set; }
        
        public string OsVersion { get; set; }

        
    }
}
