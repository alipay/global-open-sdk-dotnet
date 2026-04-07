using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipayInquireSubscriptionPaymentResponse : AMSResponse
    {

        public AlipayInquireSubscriptionPaymentResponse() { }

        

        public AlipayInquireSubscriptionPaymentResponse( Result result , List<SubscriptionTransaction> payments , Paginator paginator)
        {
            this.Result = result;
            this.Payments = payments;
            this.Paginator = paginator;
        }

            public Result Result { get; set; }
            public List<SubscriptionTransaction> Payments { get; set; }
            public Paginator Paginator { get; set; }

        

    }

}
