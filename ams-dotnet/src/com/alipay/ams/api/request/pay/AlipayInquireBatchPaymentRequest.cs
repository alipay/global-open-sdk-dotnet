using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayInquireBatchPaymentRequest : AMSRequest<AlipayInquireBatchPaymentResponse>
    {

        public AlipayInquireBatchPaymentRequest() { }

        

        public AlipayInquireBatchPaymentRequest( string batchPaymentRequestId)
        {
            this.BatchPaymentRequestId = batchPaymentRequestId;
        }

            public string BatchPaymentRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/inquireBatchPayment"; } 


    }

}
