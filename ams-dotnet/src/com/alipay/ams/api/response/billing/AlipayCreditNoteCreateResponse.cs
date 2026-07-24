using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCreditNoteCreateResponse : AMSResponse
    {

        public AlipayCreditNoteCreateResponse() { }

        

        public AlipayCreditNoteCreateResponse( Result result , string creditNoteId , string creditNoteRequestId , string invoiceId , string type , string status , string customerId , Amount totalAmount , Amount refundAmount , string refundStatus , string refundId , string reason , string reasonDescription , string refundDestination , CreditNoteCreateItems items , string memo , string effectiveDate , string issuedAt , string refundedAt , string voidedAt , string createdAt)
        {
            this.Result = result;
            this.CreditNoteId = creditNoteId;
            this.CreditNoteRequestId = creditNoteRequestId;
            this.InvoiceId = invoiceId;
            this.Type = type;
            this.Status = status;
            this.CustomerId = customerId;
            this.TotalAmount = totalAmount;
            this.RefundAmount = refundAmount;
            this.RefundStatus = refundStatus;
            this.RefundId = refundId;
            this.Reason = reason;
            this.ReasonDescription = reasonDescription;
            this.RefundDestination = refundDestination;
            this.Items = items;
            this.Memo = memo;
            this.EffectiveDate = effectiveDate;
            this.IssuedAt = issuedAt;
            this.RefundedAt = refundedAt;
            this.VoidedAt = voidedAt;
            this.CreatedAt = createdAt;
        }

            public Result Result { get; set; }
            public string CreditNoteId { get; set; }
            public string CreditNoteRequestId { get; set; }
            public string InvoiceId { get; set; }
            public string Type { get; set; }
            public string Status { get; set; }
            public string CustomerId { get; set; }
            public Amount TotalAmount { get; set; }
            public Amount RefundAmount { get; set; }
            public string RefundStatus { get; set; }
            public string RefundId { get; set; }
            public string Reason { get; set; }
            public string ReasonDescription { get; set; }
            public string RefundDestination { get; set; }
            public CreditNoteCreateItems Items { get; set; }
            public string Memo { get; set; }
            public string EffectiveDate { get; set; }
            public string IssuedAt { get; set; }
            public string RefundedAt { get; set; }
            public string VoidedAt { get; set; }
            public string CreatedAt { get; set; }

        

    }

}
