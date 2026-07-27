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

        

        public AlipayReceiptSendRequest( string receiptId , string sendRequestId)
        {
            this.ReceiptId = receiptId;
            this.SendRequestId = sendRequestId;
        }

            public string ReceiptId { get; set; }
            public string SendRequestId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/receipt/send"; } 


    }

}
