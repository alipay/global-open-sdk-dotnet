using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceSendRequest : AMSRequest<AlipayInvoiceSendResponse>
    {

        public AlipayInvoiceSendRequest() { }

        

        public AlipayInvoiceSendRequest( string invoiceId , string sendRequestId)
        {
            this.InvoiceId = invoiceId;
            this.SendRequestId = sendRequestId;
        }

            public string InvoiceId { get; set; }
            public string SendRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/send"; } 


    }

}
