using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticAuthenticationSessionMandateOrderMerchant
    {

        public AgenticAuthenticationSessionMandateOrderMerchant() { }

        

        public AgenticAuthenticationSessionMandateOrderMerchant( string referenceMerchantId , string merchantName , string merchantMCC , string merchantUrl , string merchantCountryCode)
        {
            this.ReferenceMerchantId = referenceMerchantId;
            this.MerchantName = merchantName;
            this.MerchantMCC = merchantMCC;
            this.MerchantUrl = merchantUrl;
            this.MerchantCountryCode = merchantCountryCode;
        }

            public string ReferenceMerchantId { get; set; }
            public string MerchantName { get; set; }
            public string MerchantMCC { get; set; }
            public string MerchantUrl { get; set; }
            public string MerchantCountryCode { get; set; }

        

    }

}
