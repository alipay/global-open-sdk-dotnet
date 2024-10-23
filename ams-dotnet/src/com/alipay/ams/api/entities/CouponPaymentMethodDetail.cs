namespace com.alipay.ams.api.entities;

public class CouponPaymentMethodDetail
{
    public string CouponId { get; set; }
    public Amount AvailableAmount { get; set; }
    public string CouponName { get; set; }
    public string CouponDescription { get; set; }
    public string CouponExpireTime { get; set; }
    public string PaymentMethodDetailMetadata { get; set; }
}