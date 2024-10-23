namespace com.alipay.ams.api.entities;

public class PaymentMethodDetail
{
    public PaymentMethodDetailType PaymentMethodDetailType { get; set; }
    public CardPaymentMethodDetail Card { get; set; }
    public ExternalPaymentMethodDetail ExternalAccount { get; set; }
    public DiscountPaymentMethodDetail Discount { get; set; }
    public CouponPaymentMethodDetail Coupon { get; set; }
    public string PaymentMethodType { get; set; }
    public string ExtendInfo { get; set; }
}