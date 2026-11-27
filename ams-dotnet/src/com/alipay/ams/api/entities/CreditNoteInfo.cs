using System.Collections.Generic;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.entities
{
    // Notification projection; excludes detail-only merchant metadata.
    public class CreditNoteInfo
    {
        public string CreditNoteId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public Amount TotalAmount { get; set; }
        // Optional planned original-method refund for refund-bearing POST_PAYMENT; not proof of completion.
        // Absent/null for note-only POST_PAYMENT and PRE_PAYMENT.
        public Amount RefundAmount { get; set; }
        // Optional REFUND_INITIATED, REFUND_SUCCEEDED or REFUND_FAILED progress.
        // Absent/null before progress or for note-only notes; PRE_PAYMENT may use NOT_APPLICABLE.
        public string RefundStatus { get; set; }
        // Optional payment-system reference when obtained; a reference alone does not prove success.
        // Absent/null beforehand, for note-only POST_PAYMENT and PRE_PAYMENT.
        public string RefundId { get; set; }
        // Optional REFUND routing supplied at creation; null when omitted.
        public string RefundDestination { get; set; }
        public string Reason { get; set; }
        public string ReasonDescription { get; set; }
        public string Memo { get; set; }
        public string EffectiveDate { get; set; }
        public string IssuedAt { get; set; }
        public string RefundedAt { get; set; }
        public string VoidedAt { get; set; }
        public string CreatedAt { get; set; }
        // Optional, at most 100 items; the service returns [] when absent.
        public List<NotificationLineItem> Items { get; set; }

        // Notification line item projection, without detail-only metadata.
        public class NotificationLineItem
        {
            public string CreditNoteItemId { get; set; }
            public string Type { get; set; }
            public string InvoiceItemId { get; set; }
            public string Description { get; set; }
            // Quantity mode only, from 1 to 999.
            public int? Quantity { get; set; }
            // Required C (credit) or D (debit); D itemAmount is subtracted from the credit total.
            public string Direction { get; set; }
            public Amount UnitAmount { get; set; }
            public Amount ItemAmount { get; set; }
        }
    }
}
