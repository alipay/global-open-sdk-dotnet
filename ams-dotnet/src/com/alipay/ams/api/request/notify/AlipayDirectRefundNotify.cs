using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayDirectRefundNotify : AlipayNotify
{
    /**
     * The refund status. SUCCESS/FAIL
     */
    public string RefundStatus { get; set; }

    /**
     * The unique ID that is assigned by Alipay to identify a refund
     */
    public string RefundId { get; set; }

    /**
     * The unique ID that is assigned by Alipay to identify a payment
     */
    public string PaymentId { get; set; }

    /**
     * The unique ID assigned by a merchant to identify a refund request
     */
    public string RefundRequestId { get; set; }

    /**
     * The date and time when the refund reaches a final state of success or failure
     */
    public string RefundTime { get; set; }

    /**
     * The refund from method information
     */
    public RefundFromMethod RefundFromMethod { get; set; }

    /**
     * The refund to amount
     */
    public Amount RefundToAmount { get; set; }

    /**
     * The refund from amount
     */
    public Amount RefundFromAmount { get; set; }
}
