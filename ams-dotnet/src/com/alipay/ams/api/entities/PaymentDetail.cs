namespace com.alipay.ams.api.entities;

public class PaymentDetail
{
    /**
    * The amount paid using this payment method.
    * 使用此支付方式的支付金额
    */
    private Amount Amount { get; set; }

    /**
     * The payment method used by the merchant or acquirer to collect payments.
     * 商户或收单机构用于收取款项的支付方式。
     */
    private PaymentMethod PaymentMethod { get; set; }
}