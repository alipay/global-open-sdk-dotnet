using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditNoteCreateRequest : AMSRequest<AlipayCreditNoteCreateResponse>
    {

        public AlipayCreditNoteCreateRequest() { }

        

        public AlipayCreditNoteCreateRequest( string creditNoteRequestId , string invoiceId , string type , Amount totalAmount , List<LineItem> items , Amount refundAmount , string refundDestination , string reason , string reasonDescription , string memo , string emailType , string language , string effectiveDate , Dictionary<string, string> metadata)
        {
            this.CreditNoteRequestId = creditNoteRequestId;
            this.InvoiceId = invoiceId;
            this.Type = type;
            this.TotalAmount = totalAmount;
            this.Items = items;
            this.RefundAmount = refundAmount;
            this.RefundDestination = refundDestination;
            this.Reason = reason;
            this.ReasonDescription = reasonDescription;
            this.Memo = memo;
            this.EmailType = emailType;
            this.Language = language;
            this.EffectiveDate = effectiveDate;
            this.Metadata = metadata;
        }

            public string CreditNoteRequestId { get; set; }
            public string InvoiceId { get; set; }
            public string Type { get; set; }
            public Amount TotalAmount { get; set; }
            public List<LineItem> Items { get; set; }
            public Amount RefundAmount { get; set; }
            public string RefundDestination { get; set; }
            public string Reason { get; set; }
            public string ReasonDescription { get; set; }
            public string Memo { get; set; }
            public string EmailType { get; set; }
            public string Language { get; set; }
            public string EffectiveDate { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/creditNote/create"; } 


    }

}
