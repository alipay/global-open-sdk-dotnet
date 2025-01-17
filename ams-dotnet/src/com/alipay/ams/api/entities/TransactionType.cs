namespace com.alipay.ams.api.entities;

public enum TransactionType
{
    /**
     * PAYMENT
     */
    PAYMENT,
    /**
     * REFUND
     */
    REFUND,
    /**
     * CAPTURE
     */
    CAPTURE,
    /**
     * CANCEL
     */
    CANCEL,
    /**
     * AUTH
     */
    AUTHORIZATION,
    /**
     * VOID
     */
    VOID
}