using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PriceItemChange
    {

        public PriceItemChange() { }

        

        public PriceItemChange( string changeType , string currentPriceId , string newPriceId , int? quantity)
        {
            this.ChangeType = changeType;
            this.CurrentPriceId = currentPriceId;
            this.NewPriceId = newPriceId;
            this.Quantity = quantity;
        }

            public string ChangeType { get; set; }
            public string CurrentPriceId { get; set; }
            public string NewPriceId { get; set; }
            public int? Quantity { get; set; }

        

    }

}
