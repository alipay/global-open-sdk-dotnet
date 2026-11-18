using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxExemption
    {

        public TaxExemption() { }

        

        public TaxExemption( string certificateNumber , string exemptionType , TaxExemptionJurisdiction jurisdiction , string effectiveFrom)
        {
            this.CertificateNumber = certificateNumber;
            this.ExemptionType = exemptionType;
            this.Jurisdiction = jurisdiction;
            this.EffectiveFrom = effectiveFrom;
        }

            public string CertificateNumber { get; set; }
            public string ExemptionType { get; set; }
            public TaxExemptionJurisdiction Jurisdiction { get; set; }
            public string EffectiveFrom { get; set; }

        

    }

}
