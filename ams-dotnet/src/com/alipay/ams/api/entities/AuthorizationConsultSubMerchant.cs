using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AuthorizationConsultSubMerchant
    {

        public AuthorizationConsultSubMerchant() { }

        

        public AuthorizationConsultSubMerchant( string subMerchantServiceName , string subMerchantServiceDescription)
        {
            this.SubMerchantServiceName = subMerchantServiceName;
            this.SubMerchantServiceDescription = subMerchantServiceDescription;
        }

            public string SubMerchantServiceName { get; set; }
            public string SubMerchantServiceDescription { get; set; }

        

    }

}
