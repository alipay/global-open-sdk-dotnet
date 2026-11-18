using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.agentic
{

public class AlipayInquireAccountInfoResponse : AMSResponse
    {

        public AlipayInquireAccountInfoResponse() { }

        

        public AlipayInquireAccountInfoResponse( Result result , List<AgenticBoundPaymentMethod> paymentMethods)
        {
            this.Result = result;
            this.PaymentMethods = paymentMethods;
        }

            public Result Result { get; set; }
            public List<AgenticBoundPaymentMethod> PaymentMethods { get; set; }

        

    }

}
