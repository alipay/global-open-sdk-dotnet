using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedShippingCost
    {

        public TaxCalculatedShippingCost() { }

        

        public TaxCalculatedShippingCost( string amount , string taxAmount , List<TaxBreakdown> taxBreakdown)
        {
            this.Amount = amount;
            this.TaxAmount = taxAmount;
            this.TaxBreakdown = taxBreakdown;
        }

            public string Amount { get; set; }
            public string TaxAmount { get; set; }
            public List<TaxBreakdown> TaxBreakdown { get; set; }

        

    }

}
