using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceCreateResponse : AMSResponse
    {

        public AlipayInvoiceCreateResponse() { }

        

        public AlipayInvoiceCreateResponse( Result result , string invoiceId , string invoiceRequestId , string status , string hostedInvoiceUrl , string sendStatus)
        {
            this.Result = result;
            this.InvoiceId = invoiceId;
            this.InvoiceRequestId = invoiceRequestId;
            this.Status = status;
            this.HostedInvoiceUrl = hostedInvoiceUrl;
            this.SendStatus = sendStatus;
        }

            public Result Result { get; set; }
            public string InvoiceId { get; set; }
            public string InvoiceRequestId { get; set; }
            public string Status { get; set; }
            public string HostedInvoiceUrl { get; set; }
            public string SendStatus { get; set; }

        

    }

}
