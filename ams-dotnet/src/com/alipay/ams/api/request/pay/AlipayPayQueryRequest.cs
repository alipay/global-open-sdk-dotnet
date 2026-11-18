using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayPayQueryRequest : AMSRequest<AlipayPayQueryResponse>
    {

        public AlipayPayQueryRequest() { }

        

        public AlipayPayQueryRequest( string paymentRequestId , string paymentId , string merchantAccountId)
        {
            this.PaymentRequestId = paymentRequestId;
            this.PaymentId = paymentId;
            this.MerchantAccountId = merchantAccountId;
        }

            public string PaymentRequestId { get; set; }
            public string PaymentId { get; set; }
            public string MerchantAccountId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/inquiryPayment"; } 


    }

}
