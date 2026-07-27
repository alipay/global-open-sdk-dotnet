using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PriceItem
    {

        public PriceItem() { }

        

        public PriceItem( string priceId , int? quantity)
        {
            this.PriceId = priceId;
            this.Quantity = quantity;
        }

            public string PriceId { get; set; }
            public int? Quantity { get; set; }

        

    }

}
