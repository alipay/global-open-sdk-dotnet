using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RiskEnv
    {

        public RiskEnv() { }

        

        public RiskEnv(  string  ipAddressType)
        {
            this.IpAddressType = ipAddressType;
        }

            public  string  IpAddressType { get; set; }

        

    }

}
