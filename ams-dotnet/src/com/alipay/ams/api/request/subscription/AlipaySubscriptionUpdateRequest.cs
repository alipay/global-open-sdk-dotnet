using com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.subscription
{

public class AlipaySubscriptionUpdateRequest : AMSRequest<AlipaySubscriptionUpdateResponse>
    {

        public AlipaySubscriptionUpdateRequest() { }

        

        public AlipaySubscriptionUpdateRequest( string subscriptionUpdateRequestId , string subscriptionId , string subscriptionDescription , PeriodRule periodRule , Amount paymentAmount , string subscriptionEndTime , OrderInfo orderInfo)
        {
            this.SubscriptionUpdateRequestId = subscriptionUpdateRequestId;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionDescription = subscriptionDescription;
            this.PeriodRule = periodRule;
            this.PaymentAmount = paymentAmount;
            this.SubscriptionEndTime = subscriptionEndTime;
            this.OrderInfo = orderInfo;
        }

            public string SubscriptionUpdateRequestId { get; set; }
            public string SubscriptionId { get; set; }
            public string SubscriptionDescription { get; set; }
            public PeriodRule PeriodRule { get; set; }
            public Amount PaymentAmount { get; set; }
            public string SubscriptionEndTime { get; set; }
            public OrderInfo OrderInfo { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/subscriptions/update"; } 


    }

}
