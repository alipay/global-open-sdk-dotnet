using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayInquirePaymentMethodRequest : AMSRequest<AlipayInquirePaymentMethodResponse>
    {

        public AlipayInquirePaymentMethodRequest() { }

        

        public AlipayInquirePaymentMethodRequest( string cardToken)
        {
            this.CardToken = cardToken;
        }

            public string CardToken { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/paymentMethods/inquirePaymentMethod"; } 


    }

}
