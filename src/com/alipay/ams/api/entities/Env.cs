    
namespace com.alipay.ams.api.entities
{

public class Env
    {

        public Env() { }

        public Env( TerminalType terminalType , OsType osType , string userAgent , string deviceTokenId , string clientIp , string cookieId , string extendInfo , string storeTerminalId , string storeTerminalRequestTime , BrowserInfo browserInfo , string colorDepth , string screenHeight , string screenWidth , int? timeZoneOffset , string deviceBrand , string deviceModel , string deviceLanguage , string deviceId , string envType)
        {
            this.TerminalType = terminalType;
            this.OsType = osType;
            this.UserAgent = userAgent;
            this.DeviceTokenId = deviceTokenId;
            this.ClientIp = clientIp;
            this.CookieId = cookieId;
            this.ExtendInfo = extendInfo;
            this.StoreTerminalId = storeTerminalId;
            this.StoreTerminalRequestTime = storeTerminalRequestTime;
            this.BrowserInfo = browserInfo;
            this.ColorDepth = colorDepth;
            this.ScreenHeight = screenHeight;
            this.ScreenWidth = screenWidth;
            this.TimeZoneOffset = timeZoneOffset;
            this.DeviceBrand = deviceBrand;
            this.DeviceModel = deviceModel;
            this.DeviceLanguage = deviceLanguage;
            this.DeviceId = deviceId;
            this.EnvType = envType;
        }

            public TerminalType TerminalType { get; set; }
            public OsType OsType { get; set; }
            public string UserAgent { get; set; }
            public string DeviceTokenId { get; set; }
            public string ClientIp { get; set; }
            public string CookieId { get; set; }
            public string ExtendInfo { get; set; }
            public string StoreTerminalId { get; set; }
            public string StoreTerminalRequestTime { get; set; }
            public BrowserInfo BrowserInfo { get; set; }
            public string ColorDepth { get; set; }
            public string ScreenHeight { get; set; }
            public string ScreenWidth { get; set; }
            public int? TimeZoneOffset { get; set; }
            public string DeviceBrand { get; set; }
            public string DeviceModel { get; set; }
            public string DeviceLanguage { get; set; }
            public string DeviceId { get; set; }
            public string EnvType { get; set; }

        

    }

}
