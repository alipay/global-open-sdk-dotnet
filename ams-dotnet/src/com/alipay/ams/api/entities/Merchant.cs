using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Merchant
    {

        public Merchant() { }

        public Merchant(string merchantName, string referenceMerchantId, string merchantMCC, Store store){ 
    this.MerchantName = merchantName; 
    this.ReferenceMerchantId = referenceMerchantId; 
    this.MerchantMCC = merchantMCC; 
    this.Store = store; 
} 


        public Merchant( string referenceMerchantId , string merchantMCC , string merchantName , string merchantDisplayName , Address merchantAddress , string merchantRegisterDate , Store store , MerchantType merchantType , int? numberOfTrades , AccountLastModified accountLastModified)
        {
            this.ReferenceMerchantId = referenceMerchantId;
            this.MerchantMCC = merchantMCC;
            this.MerchantName = merchantName;
            this.MerchantDisplayName = merchantDisplayName;
            this.MerchantAddress = merchantAddress;
            this.MerchantRegisterDate = merchantRegisterDate;
            this.Store = store;
            this.MerchantType = merchantType;
            this.NumberOfTrades = numberOfTrades;
            this.AccountLastModified = accountLastModified;
        }

            public string ReferenceMerchantId { get; set; }
            public string MerchantMCC { get; set; }
            public string MerchantName { get; set; }
            public string MerchantDisplayName { get; set; }
            public Address MerchantAddress { get; set; }
            public string MerchantRegisterDate { get; set; }
            public Store Store { get; set; }
            public MerchantType MerchantType { get; set; }
            public int? NumberOfTrades { get; set; }
            public AccountLastModified AccountLastModified { get; set; }

        

    }

}
