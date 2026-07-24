using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceFinalizeResponse : AMSResponse
    {

        public AlipayInvoiceFinalizeResponse() { }

        

        public AlipayInvoiceFinalizeResponse( Result result , string invoiceId , string status , string hostedInvoiceUrl , string finalizedAt , string invoiceNote , string sendStatus)
        {
            this.Result = result;
            this.InvoiceId = invoiceId;
            this.Status = status;
            this.HostedInvoiceUrl = hostedInvoiceUrl;
            this.FinalizedAt = finalizedAt;
            this.InvoiceNote = invoiceNote;
            this.SendStatus = sendStatus;
        }

            public Result Result { get; set; }
            public string InvoiceId { get; set; }
            public string Status { get; set; }
            public string HostedInvoiceUrl { get; set; }
            public string FinalizedAt { get; set; }
            public string InvoiceNote { get; set; }
            public string SendStatus { get; set; }

        

    }

}
