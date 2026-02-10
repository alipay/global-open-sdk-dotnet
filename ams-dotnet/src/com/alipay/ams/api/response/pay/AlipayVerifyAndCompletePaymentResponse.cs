using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayVerifyAndCompletePaymentResponse : AMSResponse
    {

        public AlipayVerifyAndCompletePaymentResponse() { }

        

        public AlipayVerifyAndCompletePaymentResponse( Result result , string paymentRequestId , string verifyRequestId , string paymentId , Amount paymentAmount , string paymentCreateTime , AcquirerInfo acquirerInfo)
        {
            this.Result = result;
            this.PaymentRequestId = paymentRequestId;
            this.VerifyRequestId = verifyRequestId;
            this.PaymentId = paymentId;
            this.PaymentAmount = paymentAmount;
            this.PaymentCreateTime = paymentCreateTime;
            this.AcquirerInfo = acquirerInfo;
        }

            public Result Result { get; set; }
            public string PaymentRequestId { get; set; }
            public string VerifyRequestId { get; set; }
            public string PaymentId { get; set; }
            public Amount PaymentAmount { get; set; }
            public string PaymentCreateTime { get; set; }
            public AcquirerInfo AcquirerInfo { get; set; }

        

    }

}
