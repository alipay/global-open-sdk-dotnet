using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxShippingCost
    {

        public TaxShippingCost() { }

        

        public TaxShippingCost( Amount amount)
        {
            this.Amount = amount;
        }

            public Amount Amount { get; set; }

        

    }

}
