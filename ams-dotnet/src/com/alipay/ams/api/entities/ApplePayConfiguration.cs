namespace com.alipay.ams.api.entities;

public class ApplePayConfiguration
{
    public string[] RequiredBillingContactFields  { get; set; }
    public string[] RequiredShippingContactFields { get; set; }
    public bool ButtonsBundled { get; set; }
}