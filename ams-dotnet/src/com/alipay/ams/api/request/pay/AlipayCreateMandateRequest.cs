using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayCreateMandateRequest : AMSRequest<AlipayCreateMandateResponse>
    {

        public AlipayCreateMandateRequest() { }

        

        public AlipayCreateMandateRequest( string mandateRequestId , string accessToken , Amount paymentAmount)
        {
            this.MandateRequestId = mandateRequestId;
            this.AccessToken = accessToken;
            this.PaymentAmount = paymentAmount;
        }

            public string MandateRequestId { get; set; }
            public string AccessToken { get; set; }
            public Amount PaymentAmount { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/createMandate"; } 


    }

}
