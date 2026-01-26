using com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.subscription
{

public class AlipaySubscriptionCreateRequest : AMSRequest<AlipaySubscriptionCreateResponse>
    {

        public AlipaySubscriptionCreateRequest() { }

        

        public AlipaySubscriptionCreateRequest( CustomizedInfo customizedInfo , string merchantAccountId , bool? allowAccumulate , Amount maxAccumulateAmount , bool? allowRetry , Amount maxAmountFloor , string subscriptionRequestId , string subscriptionDescription , string subscriptionRedirectUrl , string subscriptionStartTime , string subscriptionEndTime , PeriodRule periodRule , string subscriptionExpiryTime , PaymentMethod paymentMethod , string subscriptionNotificationUrl , string paymentNotificationUrl , OrderInfo orderInfo , Amount paymentAmount , SettlementStrategy settlementStrategy , Env env , List<Trial> trials)
        {
            this.CustomizedInfo = customizedInfo;
            this.MerchantAccountId = merchantAccountId;
            this.AllowAccumulate = allowAccumulate;
            this.MaxAccumulateAmount = maxAccumulateAmount;
            this.AllowRetry = allowRetry;
            this.MaxAmountFloor = maxAmountFloor;
            this.SubscriptionRequestId = subscriptionRequestId;
            this.SubscriptionDescription = subscriptionDescription;
            this.SubscriptionRedirectUrl = subscriptionRedirectUrl;
            this.SubscriptionStartTime = subscriptionStartTime;
            this.SubscriptionEndTime = subscriptionEndTime;
            this.PeriodRule = periodRule;
            this.SubscriptionExpiryTime = subscriptionExpiryTime;
            this.PaymentMethod = paymentMethod;
            this.SubscriptionNotificationUrl = subscriptionNotificationUrl;
            this.PaymentNotificationUrl = paymentNotificationUrl;
            this.OrderInfo = orderInfo;
            this.PaymentAmount = paymentAmount;
            this.SettlementStrategy = settlementStrategy;
            this.Env = env;
            this.Trials = trials;
        }

            public CustomizedInfo CustomizedInfo { get; set; }
            public string MerchantAccountId { get; set; }
            public bool? AllowAccumulate { get; set; }
            public Amount MaxAccumulateAmount { get; set; }
            public bool? AllowRetry { get; set; }
            public Amount MaxAmountFloor { get; set; }
            public string SubscriptionRequestId { get; set; }
            public string SubscriptionDescription { get; set; }
            public string SubscriptionRedirectUrl { get; set; }
            public string SubscriptionStartTime { get; set; }
            public string SubscriptionEndTime { get; set; }
            public PeriodRule PeriodRule { get; set; }
            public string SubscriptionExpiryTime { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public string SubscriptionNotificationUrl { get; set; }
            public string PaymentNotificationUrl { get; set; }
            public OrderInfo OrderInfo { get; set; }
            public Amount PaymentAmount { get; set; }
            public SettlementStrategy SettlementStrategy { get; set; }
            public Env Env { get; set; }
            public List<Trial> Trials { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/subscriptions/create"; } 


    }

}
