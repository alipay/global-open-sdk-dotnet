using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionStatusChange
    {

        public BillingSubscriptionStatusChange() { }

        

        public BillingSubscriptionStatusChange( string action)
        {
            this.Action = action;
        }

            public string Action { get; set; }

        

    }

}
