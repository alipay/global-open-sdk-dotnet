using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.entities
{
    public class NotifyInvoiceInfo
    {
        public string InvoiceId { get; set; }
        public string InvoiceStatus { get; set; }
        public Amount OriginalAmount { get; set; }
        public Amount PrePaymentCreditNotesAmount { get; set; }
        public Amount PostPaymentCreditNotesAmount { get; set; }
        public Amount AdjustedAmount { get; set; }
    }
}
