using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceReviseResponse : AMSResponse
    {

        public AlipayInvoiceReviseResponse() { }

        

        public AlipayInvoiceReviseResponse( Result result , string newInvoiceId , string voidedInvoiceId)
        {
            this.Result = result;
            this.NewInvoiceId = newInvoiceId;
            this.VoidedInvoiceId = voidedInvoiceId;
        }

            public Result Result { get; set; }
            public string NewInvoiceId { get; set; }
            public string VoidedInvoiceId { get; set; }

        

    }

}
