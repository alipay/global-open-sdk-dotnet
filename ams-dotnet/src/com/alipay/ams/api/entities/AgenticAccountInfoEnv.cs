using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticAccountInfoEnv
    {

        public AgenticAccountInfoEnv() { }

        

        public AgenticAccountInfoEnv( string terminalType , string osType , string deviceId , string deviceTokenId , string clientIp , string extendInfo , string deviceLanguage , string userAgent)
        {
            this.TerminalType = terminalType;
            this.OsType = osType;
            this.DeviceId = deviceId;
            this.DeviceTokenId = deviceTokenId;
            this.ClientIp = clientIp;
            this.ExtendInfo = extendInfo;
            this.DeviceLanguage = deviceLanguage;
            this.UserAgent = userAgent;
        }

            public string TerminalType { get; set; }
            public string OsType { get; set; }
            public string DeviceId { get; set; }
            public string DeviceTokenId { get; set; }
            public string ClientIp { get; set; }
            public string ExtendInfo { get; set; }
            public string DeviceLanguage { get; set; }
            public string UserAgent { get; set; }

        

    }

}
