using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayInvoiceConfirmPaymentResponse : AMSResponse
    {

        public AlipayInvoiceConfirmPaymentResponse() { }

        

        public AlipayInvoiceConfirmPaymentResponse( Result result , string invoiceId , string status , string receiptId , string invoiceNote , string paidAt , string sendStatus)
        {
            this.Result = result;
            this.InvoiceId = invoiceId;
            this.Status = status;
            this.ReceiptId = receiptId;
            this.InvoiceNote = invoiceNote;
            this.PaidAt = paidAt;
            this.SendStatus = sendStatus;
        }

            public Result Result { get; set; }
            public string InvoiceId { get; set; }
            public string Status { get; set; }
            public string ReceiptId { get; set; }
            public string InvoiceNote { get; set; }
            public string PaidAt { get; set; }
            public string SendStatus { get; set; }

        

    }

}
