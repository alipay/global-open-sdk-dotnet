using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCustomerCreatePortalLinkResponse : AMSResponse
    {

        public AlipayCustomerCreatePortalLinkResponse() { }

        

        public AlipayCustomerCreatePortalLinkResponse( Result result , string token , string portalUrl , string expiresAt , string sendStatus , bool? success , ErrorStack errorContext)
        {
            this.Result = result;
            this.Token = token;
            this.PortalUrl = portalUrl;
            this.ExpiresAt = expiresAt;
            this.SendStatus = sendStatus;
            this.Success = success;
            this.ErrorContext = errorContext;
        }

            public Result Result { get; set; }
            public string Token { get; set; }
            public string PortalUrl { get; set; }
            public string ExpiresAt { get; set; }
            public string SendStatus { get; set; }
            public bool? Success { get; set; }
            public ErrorStack ErrorContext { get; set; }

        

    }

}
