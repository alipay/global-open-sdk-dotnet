using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionInquireDetailsPauseCollection
    {

        public BillingSubscriptionInquireDetailsPauseCollection() { }

        

        public BillingSubscriptionInquireDetailsPauseCollection( string behavior , string resumesAt , string pausedAt , string reasonCode)
        {
            this.Behavior = behavior;
            this.ResumesAt = resumesAt;
            this.PausedAt = pausedAt;
            this.ReasonCode = reasonCode;
        }

            public string Behavior { get; set; }
            public string ResumesAt { get; set; }
            public string PausedAt { get; set; }
            public string ReasonCode { get; set; }

        

    }

}
