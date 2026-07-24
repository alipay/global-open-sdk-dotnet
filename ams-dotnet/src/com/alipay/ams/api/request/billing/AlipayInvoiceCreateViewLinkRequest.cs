using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceCreateViewLinkRequest : AMSRequest<AlipayInvoiceCreateViewLinkResponse>
    {

        public AlipayInvoiceCreateViewLinkRequest() { }

        

        public AlipayInvoiceCreateViewLinkRequest( string invoiceId , string invoiceRequestId , int? linkExpiryDays)
        {
            this.InvoiceId = invoiceId;
            this.InvoiceRequestId = invoiceRequestId;
            this.LinkExpiryDays = linkExpiryDays;
        }

            public string InvoiceId { get; set; }
            public string InvoiceRequestId { get; set; }
            public int? LinkExpiryDays { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/createViewLink"; } 


    }

}
