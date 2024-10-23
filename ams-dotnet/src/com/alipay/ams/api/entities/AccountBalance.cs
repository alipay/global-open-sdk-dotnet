namespace com.alipay.ams.api.entities;

public class AccountBalance
{
    public string AccountNo { get; set; }
    public string Currency { get; set; }
    public Amount AvailableBalance { get; set; }
    public Amount FrozenBalance { get; set; }
    public Amount TotalBalance { get; set; }
}