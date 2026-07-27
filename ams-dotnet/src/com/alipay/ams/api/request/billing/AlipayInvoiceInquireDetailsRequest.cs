using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceInquireDetailsRequest : AMSRequest<AlipayInvoiceInquireDetailsResponse>
    {

        public AlipayInvoiceInquireDetailsRequest() { }

        

        public AlipayInvoiceInquireDetailsRequest( string invoiceId , string invoiceRequestId)
        {
            this.InvoiceId = invoiceId;
            this.InvoiceRequestId = invoiceRequestId;
        }

            public string InvoiceId { get; set; }
            public string InvoiceRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/inquireDetails"; } 


    }

}
