using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.entities
{
    public class NotifyInvoiceInfo
    {
        public string InvoiceId { get; set; }
        public string InvoiceStatus { get; set; }
        // Immutable original invoice total at finalization.
        public Amount OriginalAmount { get; set; }
        // Cumulative non-voided PRE_PAYMENT amount; reduces invoice total. Zero when none.
        public Amount PrePaymentCreditNotesAmount { get; set; }
        // Cumulative non-voided POST_PAYMENT amount, including processing/failed refunds until void.
        // Does not change invoice total and is not the successfully-refunded amount.
        public Amount PostPaymentCreditNotesAmount { get; set; }
        // Current totalAmount after PRE_PAYMENT reductions; POST_PAYMENT refunds do not change it.
        // Zero may transition the invoice to PAID.
        public Amount AdjustedAmount { get; set; }
    }
}
