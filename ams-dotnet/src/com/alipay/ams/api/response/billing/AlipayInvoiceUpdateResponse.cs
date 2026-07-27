using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceUpdateResponse : AMSResponse
    {

        public AlipayInvoiceUpdateResponse() { }

        

        public AlipayInvoiceUpdateResponse( Result result , string invoiceId , string status)
        {
            this.Result = result;
            this.InvoiceId = invoiceId;
            this.Status = status;
        }

            public Result Result { get; set; }
            public string InvoiceId { get; set; }
            public string Status { get; set; }

        

    }

}
