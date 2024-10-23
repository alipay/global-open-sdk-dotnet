namespace com.alipay.ams.api.entities;

public class TransferToDetail
{
    public PaymentMethod TransferToMethod { get; set; }
    public string TransferToCurrency  { get; set; }
    public Amount FeeAmount  { get; set; }
    public Amount ActualTransferToAmount  { get; set; }
    public string PurposeCode { get; set; }
    public string TransferNotifyUrl { get; set; }
    public string TransferRemark { get; set; }
}