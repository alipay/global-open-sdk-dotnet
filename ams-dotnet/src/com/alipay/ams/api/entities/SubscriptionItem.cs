using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SubscriptionItem
    {

        public SubscriptionItem() { }

        

        public SubscriptionItem( string itemId , string priceId , int? quantity)
        {
            this.ItemId = itemId;
            this.PriceId = priceId;
            this.Quantity = quantity;
        }

            public string ItemId { get; set; }
            public string PriceId { get; set; }
            public int? Quantity { get; set; }

        

    }

}
