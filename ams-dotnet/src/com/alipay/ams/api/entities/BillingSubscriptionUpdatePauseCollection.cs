using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionUpdatePauseCollection
    {

        public BillingSubscriptionUpdatePauseCollection() { }

        

        public BillingSubscriptionUpdatePauseCollection( string behavior , string resumesAt , string reasonCode)
        {
            this.Behavior = behavior;
            this.ResumesAt = resumesAt;
            this.ReasonCode = reasonCode;
        }

            public string Behavior { get; set; }
            public string ResumesAt { get; set; }
            public string ReasonCode { get; set; }

        

    }

}
