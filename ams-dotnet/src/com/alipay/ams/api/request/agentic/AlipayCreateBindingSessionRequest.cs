using com.alipay.ams.api.response.agentic;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.agentic
{

public class AlipayCreateBindingSessionRequest : AMSRequest<AlipayCreateBindingSessionResponse>
    {

        public AlipayCreateBindingSessionRequest() { }

        

        public AlipayCreateBindingSessionRequest( string bindingRequestId , string userLoginId , AgenticBindingSessionAgent agent , bool? authorizeOnBind , AgenticPaymentMethod paymentMethod , string purchaseType , AgenticBindingSessionMandate mandate , string countryCode , string redirectUrl , AgenticSessionEnv env)
        {
            this.BindingRequestId = bindingRequestId;
            this.UserLoginId = userLoginId;
            this.Agent = agent;
            this.AuthorizeOnBind = authorizeOnBind;
            this.PaymentMethod = paymentMethod;
            this.PurchaseType = purchaseType;
            this.Mandate = mandate;
            this.CountryCode = countryCode;
            this.RedirectUrl = redirectUrl;
            this.Env = env;
        }

            public string BindingRequestId { get; set; }
            public string UserLoginId { get; set; }
            public AgenticBindingSessionAgent Agent { get; set; }
            public bool? AuthorizeOnBind { get; set; }
            public AgenticPaymentMethod PaymentMethod { get; set; }
            public string PurchaseType { get; set; }
            public AgenticBindingSessionMandate Mandate { get; set; }
            public string CountryCode { get; set; }
            public string RedirectUrl { get; set; }
            public AgenticSessionEnv Env { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/agenticPayment/createBindingSession"; } 


    }

}
