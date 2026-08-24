using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedExemption
    {

        public TaxCalculatedExemption() { }

        

        public TaxCalculatedExemption( string certificateNumber , string exemptionType , TaxCalculatedExemptionJurisdiction jurisdiction)
        {
            this.CertificateNumber = certificateNumber;
            this.ExemptionType = exemptionType;
            this.Jurisdiction = jurisdiction;
        }

            public string CertificateNumber { get; set; }
            public string ExemptionType { get; set; }
            public TaxCalculatedExemptionJurisdiction Jurisdiction { get; set; }

        

    }

}
