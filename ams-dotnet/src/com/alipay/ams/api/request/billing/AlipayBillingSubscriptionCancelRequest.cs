using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayBillingSubscriptionCancelRequest : AMSRequest<AlipayBillingSubscriptionCancelResponse>
    {

        public AlipayBillingSubscriptionCancelRequest() { }

        

        public AlipayBillingSubscriptionCancelRequest( string subscriptionId , CancellationType cancellationType , string cancellationReason , BillingSubscriptionCancelCancellationDetails cancellationDetails , string prorationBehavior)
        {
            this.SubscriptionId = subscriptionId;
            this.CancellationType = cancellationType;
            this.CancellationReason = cancellationReason;
            this.CancellationDetails = cancellationDetails;
            this.ProrationBehavior = prorationBehavior;
        }

            public string SubscriptionId { get; set; }
            public CancellationType CancellationType { get; set; }
            public string CancellationReason { get; set; }
            public BillingSubscriptionCancelCancellationDetails CancellationDetails { get; set; }
            public string ProrationBehavior { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/subscription/cancel"; } 


    }

}
