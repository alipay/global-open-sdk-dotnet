using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.notify;

public class AlipayPayResultNotify:AlipayNotify
{
    /**
     * The unique ID that is assigned by a merchant to identify a payment request.
     */
    public string PaymentRequestId { get; set; }

    /**
     * unique id generated from ipay for this payment
     */
    public string PaymentId { get; set; }

    /**
     * amount of this payment
     */
    public Amount PaymentAmount { get; set; }

    /**
     * create time of this payment
     */
    public string PaymentCreateTime { get; set; }

    /**
     * the time of payment finish
     */
    public string PaymentTime { get; set; }

    /**
     * The total amount for customs declaration
     */
    public Amount CustomsDeclarationAmount { get; set; }

    /**
     * The value of this field equals to transaction amount multiplied by the value of settlementQuote. This field is returned when the currency exchange is predetermined and the exchange rate is locked at the time of transaction
     */
    public Amount GrossSettlementAmount { get; set; }

    /**
     * The exchange rate between the settlement currency and transaction currency. This field is returned when grossSettlementAmount is returned
     */
    public Quote SettlementQuote { get; set; }

    /**
     * Information about the customer of Alipay+ Mobile Payment Provider (Alipay+ MPP)
     */
    public PspCustomerInfo PspCustomerInfo { get; set; }

    /**
     * The unique ID assigned by the non-Alipay acquirer for the transaction
     */
    public string AcquirerReferenceNo { get; set; }

    /**
     * The payment result information
     */
    public PaymentResultInfo PaymentResultInfo { get; set; }

    /**
     * The information of the acquirer that processes the payment.
     */
    public AcquirerInfo AcquirerInfo { get; set; }
    
    public PromotionResult[] PromotionResult { get; set; }


    public string PaymentMethodType { get; set; }
    
    public string Metadata { get; set; }
    
    public string SubscriptionOrderId { get; set; }
    public RetryInfo RetryInfo { get; set; }

}