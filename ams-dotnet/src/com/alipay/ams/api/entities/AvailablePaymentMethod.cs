namespace com.alipay.ams.api.entities;

public class AvailablePaymentMethod
{
    public PaymentMethodTypeItem[] PaymentMethodTypeList { get; set; }
    
    public string PaymentMethodMetaData { get; set; }
}