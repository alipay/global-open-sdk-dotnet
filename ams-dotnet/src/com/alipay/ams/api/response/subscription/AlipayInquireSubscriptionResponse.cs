using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipayInquireSubscriptionResponse : AMSResponse
    {

        public AlipayInquireSubscriptionResponse() { }

        

        public AlipayInquireSubscriptionResponse( Result result , SubscriptionInfo subscription)
        {
            this.Result = result;
            this.Subscription = subscription;
        }

            public Result Result { get; set; }
            public SubscriptionInfo Subscription { get; set; }

        

    }

}
