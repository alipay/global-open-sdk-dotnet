using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceMarkUncollectibleRequest : AMSRequest<AlipayInvoiceMarkUncollectibleResponse>
    {

        public AlipayInvoiceMarkUncollectibleRequest() { }

        

        public AlipayInvoiceMarkUncollectibleRequest( string invoiceId , string invoiceNote)
        {
            this.InvoiceId = invoiceId;
            this.InvoiceNote = invoiceNote;
        }

            public string InvoiceId { get; set; }
            public string InvoiceNote { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/markUncollectible"; } 


    }

}
