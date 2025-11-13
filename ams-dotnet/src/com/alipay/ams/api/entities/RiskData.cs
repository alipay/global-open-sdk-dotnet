using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RiskData
    {

        public RiskData() { }

        

        public RiskData(  RiskOrder  order ,  RiskBuyer  buyer ,  RiskEnv  env ,  RiskSignal  riskSignal ,  RiskAddress  address ,  CardVerificationResult  cardVerificationResult)
        {
            this.Order = order;
            this.Buyer = buyer;
            this.Env = env;
            this.RiskSignal = riskSignal;
            this.Address = address;
            this.CardVerificationResult = cardVerificationResult;
        }

            public  RiskOrder  Order { get; set; }
            public  RiskBuyer  Buyer { get; set; }
            public  RiskEnv  Env { get; set; }
            public  RiskSignal  RiskSignal { get; set; }
            public  RiskAddress  Address { get; set; }
            public  CardVerificationResult  CardVerificationResult { get; set; }

        

    }

}
