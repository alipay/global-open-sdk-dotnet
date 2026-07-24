using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayBillingSubscriptionResumeRequest : AMSRequest<AlipayBillingSubscriptionResumeResponse>
    {

        public AlipayBillingSubscriptionResumeRequest() { }

        

        public AlipayBillingSubscriptionResumeRequest( string subscriptionId , string billingCycleAnchor , string prorationBehavior , string prorationDate , string reasonCode)
        {
            this.SubscriptionId = subscriptionId;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.ProrationBehavior = prorationBehavior;
            this.ProrationDate = prorationDate;
            this.ReasonCode = reasonCode;
        }

            public string SubscriptionId { get; set; }
            public string BillingCycleAnchor { get; set; }
            public string ProrationBehavior { get; set; }
            public string ProrationDate { get; set; }
            public string ReasonCode { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/subscription/resume"; } 


    }

}
