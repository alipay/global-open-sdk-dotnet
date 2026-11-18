using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipaySubscriptionsInquiryResponse : AMSResponse
    {

        public AlipaySubscriptionsInquiryResponse() { }

        

        public AlipaySubscriptionsInquiryResponse( string allowRetry , Amount maxAmountFloor , Amount paymentAmount , PeriodRule periodRule , string subscriptionEndTime , string subscriptionRequestId , string subscriptionStartTime , string subscriptionStatus , Result result)
        {
            this.AllowRetry = allowRetry;
            this.MaxAmountFloor = maxAmountFloor;
            this.PaymentAmount = paymentAmount;
            this.PeriodRule = periodRule;
            this.SubscriptionEndTime = subscriptionEndTime;
            this.SubscriptionRequestId = subscriptionRequestId;
            this.SubscriptionStartTime = subscriptionStartTime;
            this.SubscriptionStatus = subscriptionStatus;
            this.Result = result;
        }

            public string AllowRetry { get; set; }
            public Amount MaxAmountFloor { get; set; }
            public Amount PaymentAmount { get; set; }
            public PeriodRule PeriodRule { get; set; }
            public string SubscriptionEndTime { get; set; }
            public string SubscriptionRequestId { get; set; }
            public string SubscriptionStartTime { get; set; }
            public string SubscriptionStatus { get; set; }
            public Result Result { get; set; }

        

    }

}
