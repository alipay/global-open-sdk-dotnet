namespace com.alipay.ams.api.entities;

public class Company
{
    public string LegalName { get; set; }
    public CompanyType CompanyType { get; set; }
    public Address RegisteredAddress { get; set; }
    public Address OperatingAddress { get; set; }
    public string IncorporationDate { get; set; }
    public StockInfo StockInfo { get; set; }
    public Certificate Certificates { get; set; }
    public Attachment[] Attachments { get; set; }
    public CompanyUnitType CompanyUnit { get; set; }
    public Contact[] Contacts { get; set; }
    public string VatNo { get; set; }
}