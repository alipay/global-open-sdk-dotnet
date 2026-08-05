using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify
{
    public class AlipayCreditNoteNotify : AlipayNotify
    {
        public string NotifyId { get; set; }
        public string CreditNoteRequestId { get; set; }
        public string CreditNoteNotificationType { get; set; }
        public string CustomerId { get; set; }
        public CreditNoteInfo CreditNote { get; set; }
        public NotifyInvoiceInfo Invoice { get; set; }
    }
}
