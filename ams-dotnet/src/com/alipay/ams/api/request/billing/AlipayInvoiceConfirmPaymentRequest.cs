using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayInvoiceConfirmPaymentRequest : AMSRequest<AlipayInvoiceConfirmPaymentResponse>
    {

        public AlipayInvoiceConfirmPaymentRequest() { }

        

        public AlipayInvoiceConfirmPaymentRequest( string invoiceId , string confirmationType , string paymentMethod , string reference , bool? autoSend , string invoiceNote)
        {
            this.InvoiceId = invoiceId;
            this.ConfirmationType = confirmationType;
            this.PaymentMethod = paymentMethod;
            this.Reference = reference;
            this.AutoSend = autoSend;
            this.InvoiceNote = invoiceNote;
        }

            public string InvoiceId { get; set; }
            public string ConfirmationType { get; set; }
            public string PaymentMethod { get; set; }
            public string Reference { get; set; }
            public bool? AutoSend { get; set; }
            public string InvoiceNote { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/confirmPayment"; } 


    }

}
