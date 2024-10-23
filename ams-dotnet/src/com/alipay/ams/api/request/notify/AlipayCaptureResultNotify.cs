using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayCaptureResultNotify:AlipayNotify
{
    /**
    * The unique ID that is assigned by the merchant to identify a capture request
    */
    public string CaptureRequestId { get; set; }

    /**
     * The unique ID that is assigned by Alipay to identify a payment
     */
    public string PaymentId { get; set; }

    /**
     * The unique ID assigned by Alipay to identify a capture
     */
    public string CaptureId { get; set; }

    /**
     * The capture amount that the merchant requests to receive in the transaction currency
     */
    public Amount CaptureAmount { get; set; }

    /**
     * The time when Alipay captures the payment
     */
    public string CaptureTime { get; set; }

    /**
     * The unique ID assigned by the non-Alipay acquirer for the transaction
     */
    public string AcquirerReferenceNo { get; set; }

    /**
     * The information of the acquirer that processes the payment.
     */
    public AcquirerInfo AcquirerInfo { get; set; }

}