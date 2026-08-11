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

        

        public AlipayInvoiceSendRequest( string invoiceId , List<string> ccEmails , string internalNote , bool? includePaymentLink)
        {
            this.InvoiceId = invoiceId;
            this.CcEmails = ccEmails;
            this.InternalNote = internalNote;
            this.IncludePaymentLink = includePaymentLink;
        }

            public string InvoiceId { get; set; }
            public List<string> CcEmails { get; set; }
            public string InternalNote { get; set; }
            public bool? IncludePaymentLink { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/invoice/send"; } 


    }

}
