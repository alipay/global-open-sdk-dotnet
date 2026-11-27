using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify
{
    // CREDIT_NOTE_RESULT payload; acknowledge separately with the standard Result envelope.
    public class AlipayCreditNoteNotify : AlipayNotify
    {
        // Required creation request ID shared by all events; correlation, not delivery deduplication.
        // Delivery deduplication uses outer notify_id, which is not a payload member.
        public string CreditNoteRequestId { get; set; }
        public string CreditNoteNotificationType { get; set; }
        public string CustomerId { get; set; }
        public CreditNoteInfo CreditNote { get; set; }
        public NotifyInvoiceInfo Invoice { get; set; }
    }
}
