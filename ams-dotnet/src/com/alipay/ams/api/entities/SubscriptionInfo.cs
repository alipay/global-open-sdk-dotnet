using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SubscriptionInfo
    {

        public SubscriptionInfo() { }

        

        public SubscriptionInfo( string subscriptionDescription , string subscriptionStartTime , string subscriptionEndTime , PeriodRule periodRule , List<Trial> trials , string subscriptionNotifyUrl , string subscriptionExpiryTime , bool? allowRetry , Amount maxAmountFloor)
        {
            this.SubscriptionDescription = subscriptionDescription;
            this.SubscriptionStartTime = subscriptionStartTime;
            this.SubscriptionEndTime = subscriptionEndTime;
            this.PeriodRule = periodRule;
            this.Trials = trials;
            this.SubscriptionNotifyUrl = subscriptionNotifyUrl;
            this.SubscriptionExpiryTime = subscriptionExpiryTime;
            this.AllowRetry = allowRetry;
            this.MaxAmountFloor = maxAmountFloor;
        }

            public string SubscriptionDescription { get; set; }
            public string SubscriptionStartTime { get; set; }
            public string SubscriptionEndTime { get; set; }
            public PeriodRule PeriodRule { get; set; }
            public List<Trial> Trials { get; set; }
            public string SubscriptionNotifyUrl { get; set; }
            public string SubscriptionExpiryTime { get; set; }
            public bool? AllowRetry { get; set; }
            public Amount MaxAmountFloor { get; set; }

        

    }

}
