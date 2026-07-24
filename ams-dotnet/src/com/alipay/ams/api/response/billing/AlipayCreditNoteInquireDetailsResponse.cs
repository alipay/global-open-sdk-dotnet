using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCreditNoteInquireDetailsResponse : AMSResponse
    {

        public AlipayCreditNoteInquireDetailsResponse() { }

        

        public AlipayCreditNoteInquireDetailsResponse( Result result , string creditNoteId , string creditNoteRequestId , string invoiceId , string customerId , string type , string status , Amount totalAmount , string refundStatus , string refundId , string reason , string reasonDescription , string refundDestination , string effectiveDate , string memo , CreditNoteInquireDetailsItems items , string issuedAt , string refundedAt , string voidedAt , string createdAt)
        {
            this.Result = result;
            this.CreditNoteId = creditNoteId;
            this.CreditNoteRequestId = creditNoteRequestId;
            this.InvoiceId = invoiceId;
            this.CustomerId = customerId;
            this.Type = type;
            this.Status = status;
            this.TotalAmount = totalAmount;
            this.RefundStatus = refundStatus;
            this.RefundId = refundId;
            this.Reason = reason;
            this.ReasonDescription = reasonDescription;
            this.RefundDestination = refundDestination;
            this.EffectiveDate = effectiveDate;
            this.Memo = memo;
            this.Items = items;
            this.IssuedAt = issuedAt;
            this.RefundedAt = refundedAt;
            this.VoidedAt = voidedAt;
            this.CreatedAt = createdAt;
        }

            public Result Result { get; set; }
            public string CreditNoteId { get; set; }
            public string CreditNoteRequestId { get; set; }
            public string InvoiceId { get; set; }
            public string CustomerId { get; set; }
            public string Type { get; set; }
            public string Status { get; set; }
            public Amount TotalAmount { get; set; }
            public string RefundStatus { get; set; }
            public string RefundId { get; set; }
            public string Reason { get; set; }
            public string ReasonDescription { get; set; }
            public string RefundDestination { get; set; }
            public string EffectiveDate { get; set; }
            public string Memo { get; set; }
            public CreditNoteInquireDetailsItems Items { get; set; }
            public string IssuedAt { get; set; }
            public string RefundedAt { get; set; }
            public string VoidedAt { get; set; }
            public string CreatedAt { get; set; }

        

    }

}
