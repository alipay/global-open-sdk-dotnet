using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TaxShippingCost
    {

        public TaxShippingCost() { }

        

        public TaxShippingCost( string amount)
        {
            this.Amount = amount;
        }

            public string Amount { get; set; }

        

    }

}
