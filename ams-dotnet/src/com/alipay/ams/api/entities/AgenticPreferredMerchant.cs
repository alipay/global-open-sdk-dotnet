using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticPreferredMerchant
    {

        public AgenticPreferredMerchant() { }

        

        public AgenticPreferredMerchant( string referenceMerchantId , string merchantName , string merchantMCC , string merchantUrl)
        {
            this.ReferenceMerchantId = referenceMerchantId;
            this.MerchantName = merchantName;
            this.MerchantMCC = merchantMCC;
            this.MerchantUrl = merchantUrl;
        }

            public string ReferenceMerchantId { get; set; }
            public string MerchantName { get; set; }
            public string MerchantMCC { get; set; }
            public string MerchantUrl { get; set; }

        

    }

}
