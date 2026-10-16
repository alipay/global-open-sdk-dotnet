using com.alipay.ams.api.response.agentic;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.agentic
{

public class AlipayInquirePaymentTokenRequest : AMSRequest<AlipayInquirePaymentTokenResponse>
    {

        public AlipayInquirePaymentTokenRequest() { }

        

        public AlipayInquirePaymentTokenRequest( string paymentTokenRequestId , string userLoginId , AgenticPaymentTokenAgent agent , AgenticPaymentMethod paymentMethod , string mandateId , string metadata , AgenticPaymentTokenOrder order)
        {
            this.PaymentTokenRequestId = paymentTokenRequestId;
            this.UserLoginId = userLoginId;
            this.Agent = agent;
            this.PaymentMethod = paymentMethod;
            this.MandateId = mandateId;
            this.Metadata = metadata;
            this.Order = order;
        }

            public string PaymentTokenRequestId { get; set; }
            public string UserLoginId { get; set; }
            public AgenticPaymentTokenAgent Agent { get; set; }
            public AgenticPaymentMethod PaymentMethod { get; set; }
            public string MandateId { get; set; }
            public string Metadata { get; set; }
            public AgenticPaymentTokenOrder Order { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/agenticPayment/inquirePaymentToken"; } 


    }

}
