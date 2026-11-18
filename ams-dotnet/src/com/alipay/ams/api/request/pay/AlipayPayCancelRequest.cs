using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayPayCancelRequest : AMSRequest<AlipayPayCancelResponse>
    {

        public AlipayPayCancelRequest() { }

        

        public AlipayPayCancelRequest( string paymentId , string paymentRequestId , string merchantAccountId)
        {
            this.PaymentId = paymentId;
            this.PaymentRequestId = paymentRequestId;
            this.MerchantAccountId = merchantAccountId;
        }

            public string PaymentId { get; set; }
            public string PaymentRequestId { get; set; }
            public string MerchantAccountId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/cancel"; } 


    }

}
