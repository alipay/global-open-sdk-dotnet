using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.agentic
{

public class AlipayInquirePaymentTokenResponse : AMSResponse
    {

        public AlipayInquirePaymentTokenResponse() { }

        

        public AlipayInquirePaymentTokenResponse( Result result , AgenticPaymentToken paymentToken)
        {
            this.Result = result;
            this.PaymentToken = paymentToken;
        }

            public Result Result { get; set; }
            public AgenticPaymentToken PaymentToken { get; set; }

        

    }

}
