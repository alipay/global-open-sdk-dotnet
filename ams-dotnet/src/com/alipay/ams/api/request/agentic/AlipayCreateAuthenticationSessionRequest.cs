using com.alipay.ams.api.response.agentic;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.agentic
{

public class AlipayCreateAuthenticationSessionRequest : AMSRequest<AlipayCreateAuthenticationSessionResponse>
    {

        public AlipayCreateAuthenticationSessionRequest() { }

        

        public AlipayCreateAuthenticationSessionRequest( string authenticationRequestId , string userLoginId , AgenticAuthenticationSessionAgent agent , bool? bindOnAuthorize , AgenticPaymentMethod paymentMethod , string purchaseType , AgenticAuthenticationSessionMandate mandate , string countryCode , string redirectUrl , AgenticSessionEnv env)
        {
            this.AuthenticationRequestId = authenticationRequestId;
            this.UserLoginId = userLoginId;
            this.Agent = agent;
            this.BindOnAuthorize = bindOnAuthorize;
            this.PaymentMethod = paymentMethod;
            this.PurchaseType = purchaseType;
            this.Mandate = mandate;
            this.CountryCode = countryCode;
            this.RedirectUrl = redirectUrl;
            this.Env = env;
        }

            public string AuthenticationRequestId { get; set; }
            public string UserLoginId { get; set; }
            public AgenticAuthenticationSessionAgent Agent { get; set; }
            public bool? BindOnAuthorize { get; set; }
            public AgenticPaymentMethod PaymentMethod { get; set; }
            public string PurchaseType { get; set; }
            public AgenticAuthenticationSessionMandate Mandate { get; set; }
            public string CountryCode { get; set; }
            public string RedirectUrl { get; set; }
            public AgenticSessionEnv Env { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/agenticPayment/createAuthenticationSession"; } 


    }

}
