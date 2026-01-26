using com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.subscription
{

public class AlipaySubscriptionsInquiryRequest : AMSRequest<AlipaySubscriptionsInquiryResponse>
    {

        public AlipaySubscriptionsInquiryRequest() { }

        

        public AlipaySubscriptionsInquiryRequest( string subscriptionId , string subscriptionRequestId)
        {
            this.SubscriptionId = subscriptionId;
            this.SubscriptionRequestId = subscriptionRequestId;
        }

            public string SubscriptionId { get; set; }
            public string SubscriptionRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/v1/subscriptions/inquiry"; } 


    }

}
