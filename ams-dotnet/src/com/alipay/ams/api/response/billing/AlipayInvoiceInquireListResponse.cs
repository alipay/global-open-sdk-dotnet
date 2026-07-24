using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceInquireListResponse : AMSResponse
    {

        public AlipayInvoiceInquireListResponse() { }

        

        public AlipayInvoiceInquireListResponse( Result result , List<Invoice> invoices , string total , bool? hasMore , string nextCursor)
        {
            this.Result = result;
            this.Invoices = invoices;
            this.Total = total;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

            public Result Result { get; set; }
            public List<Invoice> Invoices { get; set; }
            public string Total { get; set; }
            public bool? HasMore { get; set; }
            public string NextCursor { get; set; }

        

    }

}
