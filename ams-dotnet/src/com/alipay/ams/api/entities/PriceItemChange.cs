using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PriceItemChange
    {

        public PriceItemChange() { }

        

        public PriceItemChange( string type , string itemId , string currentPriceId , string newPriceId , int? newQuantity)
        {
            this.Type = type;
            this.ItemId = itemId;
            this.CurrentPriceId = currentPriceId;
            this.NewPriceId = newPriceId;
            this.NewQuantity = newQuantity;
        }

            public string Type { get; set; }
            public string ItemId { get; set; }
            public string CurrentPriceId { get; set; }
            public string NewPriceId { get; set; }
            public int? NewQuantity { get; set; }

        

    }

}
