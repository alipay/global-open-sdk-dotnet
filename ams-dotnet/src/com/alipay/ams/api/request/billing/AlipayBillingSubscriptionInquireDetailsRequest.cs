using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayBillingSubscriptionInquireDetailsRequest : AMSRequest<AlipayBillingSubscriptionInquireDetailsResponse>
    {

        public AlipayBillingSubscriptionInquireDetailsRequest() { }

        

        public AlipayBillingSubscriptionInquireDetailsRequest( string subscriptionId)
        {
            this.SubscriptionId = subscriptionId;
        }

            public string SubscriptionId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/subscription/inquireDetails"; } 


    }

}
