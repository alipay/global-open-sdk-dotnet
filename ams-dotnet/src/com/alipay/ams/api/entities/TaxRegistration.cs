using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxRegistration
    {

        public TaxRegistration() { }

        

        public TaxRegistration( string taxRegistrationId , string taxType , TaxJurisdiction jurisdiction , string registrationType , string taxId , string status , string activeFrom , string expireAt)
        {
            this.TaxRegistrationId = taxRegistrationId;
            this.TaxType = taxType;
            this.Jurisdiction = jurisdiction;
            this.RegistrationType = registrationType;
            this.TaxId = taxId;
            this.Status = status;
            this.ActiveFrom = activeFrom;
            this.ExpireAt = expireAt;
        }

            public string TaxRegistrationId { get; set; }
            public string TaxType { get; set; }
            public TaxJurisdiction Jurisdiction { get; set; }
            public string RegistrationType { get; set; }
            public string TaxId { get; set; }
            public string Status { get; set; }
            public string ActiveFrom { get; set; }
            public string ExpireAt { get; set; }

        

    }

}
