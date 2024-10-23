namespace com.alipay.ams.api.entities;

public class DiscountPaymentMethodDetail
{
    public string DiscountId { get; set; }
    public Amount AvailableAmount { get; set; }
    public string DiscountName { get; set; }
    public string DiscountDescription { get; set; }
    public string PaymentMethodDetailMetadata { get; set; }
}