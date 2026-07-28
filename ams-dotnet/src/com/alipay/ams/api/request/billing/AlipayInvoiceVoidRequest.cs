using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceVoidRequest : AMSRequest<AlipayInvoiceVoidResponse>
    {

        public AlipayInvoiceVoidRequest() { }

        

        public AlipayInvoiceVoidRequest( string voidRequestId , string invoiceId , string invoiceNote)
        {
            this.VoidRequestId = voidRequestId;
            this.InvoiceId = invoiceId;
            this.InvoiceNote = invoiceNote;
        }

            public string VoidRequestId { get; set; }
            public string InvoiceId { get; set; }
            public string InvoiceNote { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/void"; } 


    }

}
