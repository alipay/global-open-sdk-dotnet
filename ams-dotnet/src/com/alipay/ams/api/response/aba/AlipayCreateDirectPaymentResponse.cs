using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayCreateDirectPaymentResponse : AMSResponse
    {

        public AlipayCreateDirectPaymentResponse() { }

        

        public AlipayCreateDirectPaymentResponse( string paymentId , string paymentRequestId , PaymentMethod payToMethod , Amount payFromAmount , Amount payToAmount , string paymentTime , Result result)
        {
            this.PaymentId = paymentId;
            this.PaymentRequestId = paymentRequestId;
            this.PayToMethod = payToMethod;
            this.PayFromAmount = payFromAmount;
            this.PayToAmount = payToAmount;
            this.PaymentTime = paymentTime;
            this.Result = result;
        }

            public string PaymentId { get; set; }
            public string PaymentRequestId { get; set; }
            public PaymentMethod PayToMethod { get; set; }
            public Amount PayFromAmount { get; set; }
            public Amount PayToAmount { get; set; }
            public string PaymentTime { get; set; }
            public Result Result { get; set; }

        

    }

}
