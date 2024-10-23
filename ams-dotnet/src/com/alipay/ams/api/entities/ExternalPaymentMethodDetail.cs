namespace com.alipay.ams.api.entities;

public class ExternalPaymentMethodDetail
{
    public string AssetToken { get; set; }
    public string AccountDisplayName { get; set; }
    public string DisableReason { get; set; }
    public string PaymentMethodDetailMetadata { get; set; }
}