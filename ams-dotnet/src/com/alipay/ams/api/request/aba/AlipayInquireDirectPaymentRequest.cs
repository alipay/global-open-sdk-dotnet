using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireDirectPaymentRequest : AMSRequest<AlipayInquireDirectPaymentResponse>
    {

        public AlipayInquireDirectPaymentRequest() { }

        

        public AlipayInquireDirectPaymentRequest( string paymentId , string paymentRequestId)
        {
            this.PaymentId = paymentId;
            this.PaymentRequestId = paymentRequestId;
        }

            public string PaymentId { get; set; }
            public string PaymentRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/aba/funds/inquireDirectPayment"; } 


    }

}
