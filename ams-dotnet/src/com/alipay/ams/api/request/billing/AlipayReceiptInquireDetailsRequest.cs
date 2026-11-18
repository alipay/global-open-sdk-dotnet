using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayReceiptInquireDetailsRequest : AMSRequest<AlipayReceiptInquireDetailsResponse>
    {

        public AlipayReceiptInquireDetailsRequest() { }

        

        public AlipayReceiptInquireDetailsRequest( string receiptId , string invoiceId)
        {
            this.ReceiptId = receiptId;
            this.InvoiceId = invoiceId;
        }

            public string ReceiptId { get; set; }
            public string InvoiceId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/receipt/inquireDetails"; } 


    }

}
