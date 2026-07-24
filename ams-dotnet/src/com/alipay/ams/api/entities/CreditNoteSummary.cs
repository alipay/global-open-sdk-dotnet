using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CreditNoteSummary
    {

        public CreditNoteSummary() { }

        

        public CreditNoteSummary( string creditNoteId , string customerId , string invoiceId , string type , string status , Amount totalAmount , string reason , string effectiveDate , string refundStatus , string voidedAt , string refundedAt , string createdAt)
        {
            this.CreditNoteId = creditNoteId;
            this.CustomerId = customerId;
            this.InvoiceId = invoiceId;
            this.Type = type;
            this.Status = status;
            this.TotalAmount = totalAmount;
            this.Reason = reason;
            this.EffectiveDate = effectiveDate;
            this.RefundStatus = refundStatus;
            this.VoidedAt = voidedAt;
            this.RefundedAt = refundedAt;
            this.CreatedAt = createdAt;
        }

            public string CreditNoteId { get; set; }
            public string CustomerId { get; set; }
            public string InvoiceId { get; set; }
            public string Type { get; set; }
            public string Status { get; set; }
            public Amount TotalAmount { get; set; }
            public string Reason { get; set; }
            public string EffectiveDate { get; set; }
            public string RefundStatus { get; set; }
            public string VoidedAt { get; set; }
            public string RefundedAt { get; set; }
            public string CreatedAt { get; set; }

        

    }

}
