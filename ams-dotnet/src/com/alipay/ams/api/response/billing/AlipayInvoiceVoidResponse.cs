using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceVoidResponse : AMSResponse
    {

        public AlipayInvoiceVoidResponse() { }

        

        public AlipayInvoiceVoidResponse( Result result , string voidRequestId , string invoiceId , string status , string voidedAt , string invoiceNote)
        {
            this.Result = result;
            this.VoidRequestId = voidRequestId;
            this.InvoiceId = invoiceId;
            this.Status = status;
            this.VoidedAt = voidedAt;
            this.InvoiceNote = invoiceNote;
        }

            public Result Result { get; set; }
            public string VoidRequestId { get; set; }
            public string InvoiceId { get; set; }
            public string Status { get; set; }
            public string VoidedAt { get; set; }
            public string InvoiceNote { get; set; }

        

    }

}
