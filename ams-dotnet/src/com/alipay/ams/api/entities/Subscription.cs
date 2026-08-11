using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Subscription
    {

        public Subscription() { }

        

        public Subscription( string subscriptionId , string subscriptionRequestId , string status , string customerId , string description , string billingMode , string currentPeriodStart , string currentPeriodEnd , bool? cancelAtPeriodEnd , string canceledAt , string cancelAt , string billingCycleAnchor , string trialStart , string trialEnd , Amount subtotal , Amount discountAmount , Amount totalAmount , List<BillingSubscriptionPriceItem> priceItems , string terminationReason , string createTime)
        {
            this.SubscriptionId = subscriptionId;
            this.SubscriptionRequestId = subscriptionRequestId;
            this.Status = status;
            this.CustomerId = customerId;
            this.Description = description;
            this.BillingMode = billingMode;
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.CanceledAt = canceledAt;
            this.CancelAt = cancelAt;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.TrialStart = trialStart;
            this.TrialEnd = trialEnd;
            this.Subtotal = subtotal;
            this.DiscountAmount = discountAmount;
            this.TotalAmount = totalAmount;
            this.PriceItems = priceItems;
            this.TerminationReason = terminationReason;
            this.CreateTime = createTime;
        }

            public string SubscriptionId { get; set; }
            public string SubscriptionRequestId { get; set; }
            public string Status { get; set; }
            public string CustomerId { get; set; }
            public string Description { get; set; }
            public string BillingMode { get; set; }
            public string CurrentPeriodStart { get; set; }
            public string CurrentPeriodEnd { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string CanceledAt { get; set; }
            public string CancelAt { get; set; }
            public string BillingCycleAnchor { get; set; }
            public string TrialStart { get; set; }
            public string TrialEnd { get; set; }
            public Amount Subtotal { get; set; }
            public Amount DiscountAmount { get; set; }
            public Amount TotalAmount { get; set; }
            public List<BillingSubscriptionPriceItem> PriceItems { get; set; }
            public string TerminationReason { get; set; }
            public string CreateTime { get; set; }

        

    }

}
