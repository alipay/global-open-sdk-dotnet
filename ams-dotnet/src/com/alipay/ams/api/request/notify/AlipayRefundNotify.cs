using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayRefundNotify:AlipayNotify
{
    /**
     * Indicates the refund result. SUCCESS/FAIL
     */
    public string RefundStatus { get; set; }

    /**
     * The unique ID assigned by a merchant to identify a refund request
     */
    public string RefundRequestId { get; set; }

    /**
     * The unique ID that is assigned by Alipay to identify a refund. A one-to-one correspondence between paymentId and paymentRequestId exists
     */
    public string RefundId { get; set; }

    /**
     * The refund amount that is initiated by the merchant
     */
    public string RefundAmount { get; set; }

    /**
     * The date and time when the refund reaches a final state of success or failure
     */
    public string RefundTime { get; set; }

    /**
     * The refund settlement amount, which equals the refund amount multiplied by the value of settlementQuote
     */
    public Amount GrossSettlementAmount { get; set; }

    /**
     * The exchange rate between the settlement currency and transaction currency
     */
    public Quote SettlementQuote { get; set; }
    
    
    public CustomizedInfo CustomizedInfo { get; set; }

    public string Arn { get; set; }

    public Amount ActualRefundAmount { get; set; }
    
    public string Metadata { get; set; }
}