using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxCalculatedShippingCost
    {

        public TaxCalculatedShippingCost() { }

        

        public TaxCalculatedShippingCost( Amount amount , Amount taxAmount , List<TaxBreakdown> taxBreakdown)
        {
            this.Amount = amount;
            this.TaxAmount = taxAmount;
            this.TaxBreakdown = taxBreakdown;
        }

            public Amount Amount { get; set; }
            public Amount TaxAmount { get; set; }
            public List<TaxBreakdown> TaxBreakdown { get; set; }

        

    }

}
