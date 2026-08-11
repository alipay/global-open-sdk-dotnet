using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SubscriptionItem
    {

        public SubscriptionItem() { }

        

        public SubscriptionItem( string itemId , string priceId , int? quantity , string currentPeriodStart , string currentPeriodEnd , int? recurringIntervalCount)
        {
            this.ItemId = itemId;
            this.PriceId = priceId;
            this.Quantity = quantity;
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.RecurringIntervalCount = recurringIntervalCount;
        }

            public string ItemId { get; set; }
            public string PriceId { get; set; }
            public int? Quantity { get; set; }
            public string CurrentPeriodStart { get; set; }
            public string CurrentPeriodEnd { get; set; }
            public int? RecurringIntervalCount { get; set; }

        

    }

}
