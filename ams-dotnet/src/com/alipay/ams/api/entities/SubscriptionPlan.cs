using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SubscriptionPlan
    {

        public SubscriptionPlan() { }

        

        public SubscriptionPlan( bool? allowAccumulate , Amount maxAccumulateAmount , PeriodRule periodRule , string subscriptionStartTime , string subscriptionNotificationUrl)
        {
            this.AllowAccumulate = allowAccumulate;
            this.MaxAccumulateAmount = maxAccumulateAmount;
            this.PeriodRule = periodRule;
            this.SubscriptionStartTime = subscriptionStartTime;
            this.SubscriptionNotificationUrl = subscriptionNotificationUrl;
        }

            public bool? AllowAccumulate { get; set; }
            public Amount MaxAccumulateAmount { get; set; }
            public PeriodRule PeriodRule { get; set; }
            public string SubscriptionStartTime { get; set; }
            public string SubscriptionNotificationUrl { get; set; }

        

    }

}
