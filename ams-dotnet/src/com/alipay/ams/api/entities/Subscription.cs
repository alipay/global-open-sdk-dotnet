using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Subscription
    {

        public Subscription() { }

        

        public Subscription( string subscriptionId , string status , string customerId , string currentPeriodEnd , string createdAt)
        {
            this.SubscriptionId = subscriptionId;
            this.Status = status;
            this.CustomerId = customerId;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.CreatedAt = createdAt;
        }

            public string SubscriptionId { get; set; }
            public string Status { get; set; }
            public string CustomerId { get; set; }
            public string CurrentPeriodEnd { get; set; }
            public string CreatedAt { get; set; }

        

    }

}
