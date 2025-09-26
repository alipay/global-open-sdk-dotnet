    
namespace com.alipay.ams.api.entities
{

public class Merchant
    {

        public Merchant() { }

        public Merchant( string referenceMerchantId , string merchantMCC , string merchantName , string merchantDisplayName , Address merchantAddress , string merchantRegisterDate , Store store , MerchantType merchantType)
        {
            this.ReferenceMerchantId = referenceMerchantId;
            this.MerchantMCC = merchantMCC;
            this.MerchantName = merchantName;
            this.MerchantDisplayName = merchantDisplayName;
            this.MerchantAddress = merchantAddress;
            this.MerchantRegisterDate = merchantRegisterDate;
            this.Store = store;
            this.MerchantType = merchantType;
        }

            public string ReferenceMerchantId { get; set; }
            public string MerchantMCC { get; set; }
            public string MerchantName { get; set; }
            public string MerchantDisplayName { get; set; }
            public Address MerchantAddress { get; set; }
            public string MerchantRegisterDate { get; set; }
            public Store Store { get; set; }
            public MerchantType MerchantType { get; set; }

        

    }

}
