using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceSendResponse : AMSResponse
    {

        public AlipayInvoiceSendResponse() { }

        

        public AlipayInvoiceSendResponse( Result result , string invoiceId , string sendStatus , string hostedInvoiceUrl)
        {
            this.Result = result;
            this.InvoiceId = invoiceId;
            this.SendStatus = sendStatus;
            this.HostedInvoiceUrl = hostedInvoiceUrl;
        }

            public Result Result { get; set; }
            public string InvoiceId { get; set; }
            public string SendStatus { get; set; }
            public string HostedInvoiceUrl { get; set; }

        

    }

}
