using System.Collections.Generic;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.entities
{
    public class CreditNoteInfo
    {
        public string CreditNoteId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public Amount TotalAmount { get; set; }
        public Amount RefundAmount { get; set; }
        public string RefundStatus { get; set; }
        public string RefundId { get; set; }
        public string RefundDestination { get; set; }
        public string Reason { get; set; }
        public string ReasonDescription { get; set; }
        public string Memo { get; set; }
        public string EffectiveDate { get; set; }
        public string IssuedAt { get; set; }
        public string RefundedAt { get; set; }
        public string VoidedAt { get; set; }
        public string CreatedAt { get; set; }
        public List<LineItem> Items { get; set; }
    }
}
