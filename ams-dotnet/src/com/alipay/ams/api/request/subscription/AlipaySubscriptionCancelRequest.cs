using com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.subscription
{

public class AlipaySubscriptionCancelRequest : AMSRequest<AlipaySubscriptionCancelResponse>
    {

        public AlipaySubscriptionCancelRequest() { }

        

        public AlipaySubscriptionCancelRequest(  string  subscriptionId ,  string  subscriptionRequestId ,  string  cancellationType)
        {
            this.SubscriptionId = subscriptionId;
            this.SubscriptionRequestId = subscriptionRequestId;
            this.CancellationType = cancellationType;
        }

            public  string  SubscriptionId { get; set; }
            public  string  SubscriptionRequestId { get; set; }
            public  string  CancellationType { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/subscriptions/cancel"; } 


    }

}
