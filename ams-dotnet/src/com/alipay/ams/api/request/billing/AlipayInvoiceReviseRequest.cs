using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceReviseRequest : AMSRequest<AlipayInvoiceReviseResponse>
    {

        public AlipayInvoiceReviseRequest() { }

        

        public AlipayInvoiceReviseRequest( string invoiceId , string invoiceRequestId , string invoiceRevisionRequestId , bool? _void)
        {
            this.InvoiceId = invoiceId;
            this.InvoiceRequestId = invoiceRequestId;
            this.InvoiceRevisionRequestId = invoiceRevisionRequestId;
            this.Void = _void;
        }

            public string InvoiceId { get; set; }
            public string InvoiceRequestId { get; set; }
            public string InvoiceRevisionRequestId { get; set; }
            public bool? Void { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/revise"; } 


    }

}
