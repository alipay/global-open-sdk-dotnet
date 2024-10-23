namespace com.alipay.ams.api.entities;

public class TransferFromDetail
{
    public PaymentMethod TransferFromMethod { get; set; }
    public Amount TransferFromAmount { get; set; }
}