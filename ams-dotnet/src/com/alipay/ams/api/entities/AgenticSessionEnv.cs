using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticSessionEnv
    {

        public AgenticSessionEnv() { }

        

        public AgenticSessionEnv( string terminalType , string deviceBrand , string deviceId , string osType , string clientIp)
        {
            this.TerminalType = terminalType;
            this.DeviceBrand = deviceBrand;
            this.DeviceId = deviceId;
            this.OsType = osType;
            this.ClientIp = clientIp;
        }

            public string TerminalType { get; set; }
            public string DeviceBrand { get; set; }
            public string DeviceId { get; set; }
            public string OsType { get; set; }
            public string ClientIp { get; set; }

        

    }

}
