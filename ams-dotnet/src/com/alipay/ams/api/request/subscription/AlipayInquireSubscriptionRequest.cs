using com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.subscription
{

public class AlipayInquireSubscriptionRequest : AMSRequest<AlipayInquireSubscriptionResponse>
    {

        public AlipayInquireSubscriptionRequest() { }

        

        public AlipayInquireSubscriptionRequest( string merchantAccountId , string subscriptionId)
        {
            this.MerchantAccountId = merchantAccountId;
            this.SubscriptionId = subscriptionId;
        }

            public string MerchantAccountId { get; set; }
            public string SubscriptionId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/subscriptions/inquireSubscription"; } 


    }

}
