namespace com.alipay.ams.api.entities;

public class PaymentMethodTypeItem
{
    public string PaymentMethodType { get; set; }
    public int PaymentMethodOrder { get; set; }
    public bool ExpressCheckout { get; set; }
}