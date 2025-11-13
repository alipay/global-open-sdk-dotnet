using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class MerchantInfo
    {

        public MerchantInfo() { }

        

        public MerchantInfo(  string  referenceMerchantId ,  string  loginId ,  LegalEntityType  legalEntityType ,  Company  company ,  BusinessInfo  businessInfo ,  List<EntityAssociations>  entityAssociations)
        {
            this.ReferenceMerchantId = referenceMerchantId;
            this.LoginId = loginId;
            this.LegalEntityType = legalEntityType;
            this.Company = company;
            this.BusinessInfo = businessInfo;
            this.EntityAssociations = entityAssociations;
        }

            public  string  ReferenceMerchantId { get; set; }
            public  string  LoginId { get; set; }
            public  LegalEntityType  LegalEntityType { get; set; }
            public  Company  Company { get; set; }
            public  BusinessInfo  BusinessInfo { get; set; }
            public  List<EntityAssociations>  EntityAssociations { get; set; }

        

    }

}
