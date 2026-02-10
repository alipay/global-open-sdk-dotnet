using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayVerifyAndCompletePaymentRequest : AMSRequest<AlipayVerifyAndCompletePaymentResponse>
    {

        public AlipayVerifyAndCompletePaymentRequest() { }

        

        public AlipayVerifyAndCompletePaymentRequest( VerifyMethod verifyMethod , string verifyRequestId , string paymentId)
        {
            this.VerifyMethod = verifyMethod;
            this.VerifyRequestId = verifyRequestId;
            this.PaymentId = paymentId;
        }

            public VerifyMethod VerifyMethod { get; set; }
            public string VerifyRequestId { get; set; }
            public string PaymentId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/verifyAndCompletePayment"; } 


    }

}
