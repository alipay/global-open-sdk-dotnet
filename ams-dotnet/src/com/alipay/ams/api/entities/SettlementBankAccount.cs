namespace com.alipay.ams.api.entities;

public class SettlementBankAccount
{
    public string BankAccountNo { get; set; }
    public string AccountHolderName { get; set; }
    public string SwiftCode { get; set; }
    public string BankRegion { get; set; }
    public AccountHolderType AccountHolderType { get; set; }
    public string RoutingNumber { get; set; }
    public string BranchCode { get; set; }
    public string AccountHolderTIN { get; set; }
    public AccountType AccountType { get; set; }
    public string BankName { get; set; }
    public Address AccountHolderAddress { get; set; }
    public string Iban { get; set; }
}