    
namespace com.alipay.ams.api.entities
{

public class Company
    {

        public Company() { }

        public Company( string legalName , CompanyType companyType , Address registeredAddress , Address operatingAddress , string incorporationDate , StockInfo stockInfo , Certificate certificates , List<Attachment> attachments , CompanyUnitType companyUnit , List<Contact> contacts , string vatNo)
        {
            this.LegalName = legalName;
            this.CompanyType = companyType;
            this.RegisteredAddress = registeredAddress;
            this.OperatingAddress = operatingAddress;
            this.IncorporationDate = incorporationDate;
            this.StockInfo = stockInfo;
            this.Certificates = certificates;
            this.Attachments = attachments;
            this.CompanyUnit = companyUnit;
            this.Contacts = contacts;
            this.VatNo = vatNo;
        }

            public string LegalName { get; set; }
            public CompanyType CompanyType { get; set; }
            public Address RegisteredAddress { get; set; }
            public Address OperatingAddress { get; set; }
            public string IncorporationDate { get; set; }
            public StockInfo StockInfo { get; set; }
            public Certificate Certificates { get; set; }
            public List<Attachment> Attachments { get; set; }
            public CompanyUnitType CompanyUnit { get; set; }
            public List<Contact> Contacts { get; set; }
            public string VatNo { get; set; }

        

    }

}
