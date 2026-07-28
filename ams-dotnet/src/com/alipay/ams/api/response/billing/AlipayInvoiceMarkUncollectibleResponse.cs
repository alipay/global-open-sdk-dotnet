using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceMarkUncollectibleResponse : AMSResponse
    {

        public AlipayInvoiceMarkUncollectibleResponse() { }

        

        public AlipayInvoiceMarkUncollectibleResponse( Result result , string invoiceId , string status , string markedUncollectibleAt , string invoiceNote)
        {
            this.Result = result;
            this.InvoiceId = invoiceId;
            this.Status = status;
            this.MarkedUncollectibleAt = markedUncollectibleAt;
            this.InvoiceNote = invoiceNote;
        }

            public Result Result { get; set; }
            public string InvoiceId { get; set; }
            public string Status { get; set; }
            public string MarkedUncollectibleAt { get; set; }
            public string InvoiceNote { get; set; }

        

    }

}
