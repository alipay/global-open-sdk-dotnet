using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayReceiptSendRequest : AMSRequest<AlipayReceiptSendResponse>
    {

        public AlipayReceiptSendRequest() { }

        

        public AlipayReceiptSendRequest( string receiptId , List<string> ccEmails)
        {
            this.ReceiptId = receiptId;
            this.CcEmails = ccEmails;
        }

            public string ReceiptId { get; set; }
            public List<string> CcEmails { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/receipt/send"; } 


    }

}
