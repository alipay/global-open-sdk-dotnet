using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RiskSignal
    {

        public RiskSignal() { }

        

        public RiskSignal(  string  riskCode ,  string  riskReason)
        {
            this.RiskCode = riskCode;
            this.RiskReason = riskReason;
        }

            public  string  RiskCode { get; set; }
            public  string  RiskReason { get; set; }

        

    }

}
