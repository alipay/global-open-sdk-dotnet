using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayUpdateAmountRequest : AMSRequest<AlipayUpdateAmountResponse>
    {

        public AlipayUpdateAmountRequest() { }

        

        public AlipayUpdateAmountRequest( string updateRequestId , string paymentId , Amount amount)
        {
            this.UpdateRequestId = updateRequestId;
            this.PaymentId = paymentId;
            this.Amount = amount;
        }

            public string UpdateRequestId { get; set; }
            public string PaymentId { get; set; }
            public Amount Amount { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/updateAmount"; } 


    }

}
