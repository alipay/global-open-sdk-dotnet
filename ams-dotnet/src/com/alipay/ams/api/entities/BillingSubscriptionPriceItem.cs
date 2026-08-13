using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscriptionPriceItem
    {

        public BillingSubscriptionPriceItem() { }

        

        public BillingSubscriptionPriceItem( string currentPeriodEnd , string currentPeriodStart , Amount itemAmount , string itemId , string nickname , string priceId , string priceType , string pricingModel , string productId , string productName , int? quantity , string recurringInterval , int? recurringIntervalCount , Amount unitAmount , string usageType)
        {
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.CurrentPeriodStart = currentPeriodStart;
            this.ItemAmount = itemAmount;
            this.ItemId = itemId;
            this.Nickname = nickname;
            this.PriceId = priceId;
            this.PriceType = priceType;
            this.PricingModel = pricingModel;
            this.ProductId = productId;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.RecurringInterval = recurringInterval;
            this.RecurringIntervalCount = recurringIntervalCount;
            this.UnitAmount = unitAmount;
            this.UsageType = usageType;
        }

            public string CurrentPeriodEnd { get; set; }
            public string CurrentPeriodStart { get; set; }
            public Amount ItemAmount { get; set; }
            public string ItemId { get; set; }
            public string Nickname { get; set; }
            public string PriceId { get; set; }
            public string PriceType { get; set; }
            public string PricingModel { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public int? Quantity { get; set; }
            public string RecurringInterval { get; set; }
            public int? RecurringIntervalCount { get; set; }
            public Amount UnitAmount { get; set; }
            public string UsageType { get; set; }

        

    }

}
