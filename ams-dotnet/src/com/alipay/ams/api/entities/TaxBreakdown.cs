using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxBreakdown
    {

        public TaxBreakdown() { }

        

        public TaxBreakdown( string taxType , string authorityName , string taxRate , string taxAmount , string taxableAmount , string taxabilityReason , bool? inclusive)
        {
            this.TaxType = taxType;
            this.AuthorityName = authorityName;
            this.TaxRate = taxRate;
            this.TaxAmount = taxAmount;
            this.TaxableAmount = taxableAmount;
            this.TaxabilityReason = taxabilityReason;
            this.Inclusive = inclusive;
        }

            public string TaxType { get; set; }
            public string AuthorityName { get; set; }
            public string TaxRate { get; set; }
            public string TaxAmount { get; set; }
            public string TaxableAmount { get; set; }
            public string TaxabilityReason { get; set; }
            public bool? Inclusive { get; set; }

        

    }

}
