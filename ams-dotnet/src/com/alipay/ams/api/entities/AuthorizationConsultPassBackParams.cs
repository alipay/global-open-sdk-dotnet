using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthorizationConsultPassBackParams
    {

        public AuthorizationConsultPassBackParams() { }

        

        public AuthorizationConsultPassBackParams( string subscriptionId , string itemId)
        {
            this.SubscriptionId = subscriptionId;
            this.ItemId = itemId;
        }

            public string SubscriptionId { get; set; }
            public string ItemId { get; set; }

        

    }

}
