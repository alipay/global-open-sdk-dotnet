using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceCreateViewLinkResponse : AMSResponse
    {

        public AlipayInvoiceCreateViewLinkResponse() { }

        

        public AlipayInvoiceCreateViewLinkResponse( InvoiceCreateViewLinkResult result , string token , string viewUrl , string expiresAt)
        {
            this.Result = result;
            this.Token = token;
            this.ViewUrl = viewUrl;
            this.ExpiresAt = expiresAt;
        }

            public InvoiceCreateViewLinkResult Result { get; set; }
            public string Token { get; set; }
            public string ViewUrl { get; set; }
            public string ExpiresAt { get; set; }

        

    }

}
