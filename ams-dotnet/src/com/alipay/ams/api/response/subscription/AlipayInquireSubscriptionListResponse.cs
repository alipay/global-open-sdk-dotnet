using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipayInquireSubscriptionListResponse : AMSResponse
    {

        public AlipayInquireSubscriptionListResponse() { }

        

        public AlipayInquireSubscriptionListResponse( Result result , List<SubscriptionInfo> subscriptions , Paginator paginator)
        {
            this.Result = result;
            this.Subscriptions = subscriptions;
            this.Paginator = paginator;
        }

            public Result Result { get; set; }
            public List<SubscriptionInfo> Subscriptions { get; set; }
            public Paginator Paginator { get; set; }

        

    }

}
