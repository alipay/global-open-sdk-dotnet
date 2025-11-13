using com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.subscription
{

public class AlipaySubscriptionChangeRequest : AMSRequest<AlipaySubscriptionChangeResponse>
    {

        public AlipaySubscriptionChangeRequest() { }

        

        public AlipaySubscriptionChangeRequest(  string  subscriptionChangeRequestId ,  string  subscriptionId ,  string  subscriptionDescription ,  string  subscriptionStartTime ,  string  subscriptionEndTime ,  PeriodRule  periodRule ,  string  subscriptionExpiryTime ,  OrderInfo  orderInfo ,  Amount  paymentAmount ,  Amount  paymentAmountDifference)
        {
            this.SubscriptionChangeRequestId = subscriptionChangeRequestId;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionDescription = subscriptionDescription;
            this.SubscriptionStartTime = subscriptionStartTime;
            this.SubscriptionEndTime = subscriptionEndTime;
            this.PeriodRule = periodRule;
            this.SubscriptionExpiryTime = subscriptionExpiryTime;
            this.OrderInfo = orderInfo;
            this.PaymentAmount = paymentAmount;
            this.PaymentAmountDifference = paymentAmountDifference;
        }

            public  string  SubscriptionChangeRequestId { get; set; }
            public  string  SubscriptionId { get; set; }
            public  string  SubscriptionDescription { get; set; }
            public  string  SubscriptionStartTime { get; set; }
            public  string  SubscriptionEndTime { get; set; }
            public  PeriodRule  PeriodRule { get; set; }
            public  string  SubscriptionExpiryTime { get; set; }
            public  OrderInfo  OrderInfo { get; set; }
            public  Amount  PaymentAmount { get; set; }
            public  Amount  PaymentAmountDifference { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/subscriptions/change"; } 


    }

}
