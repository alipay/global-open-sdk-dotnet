using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayReceiptSendResponse : AMSResponse
    {

        public AlipayReceiptSendResponse() { }

        

        public AlipayReceiptSendResponse( Result result , string receiptId , string sendStatus , string hostedReceiptUrl)
        {
            this.Result = result;
            this.ReceiptId = receiptId;
            this.SendStatus = sendStatus;
            this.HostedReceiptUrl = hostedReceiptUrl;
        }

            public Result Result { get; set; }
            public string ReceiptId { get; set; }
            public string SendStatus { get; set; }
            public string HostedReceiptUrl { get; set; }

        

    }

}
