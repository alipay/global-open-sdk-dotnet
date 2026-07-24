using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BillingSubscription
    {

        public BillingSubscription() { }

        

        public BillingSubscription( string customerId , BillingTrialSettings trialSettings , string paymentBehavior , string collectionMethod , int? daysUntilDue , string billingCycleAnchor , string cancelAt , bool? cancelAtPeriodEnd , string description , List<BillingSubscriptionDiscount> discounts , bool? allowPromotionCode , string subscriptionNotifyUrl)
        {
            this.CustomerId = customerId;
            this.TrialSettings = trialSettings;
            this.PaymentBehavior = paymentBehavior;
            this.CollectionMethod = collectionMethod;
            this.DaysUntilDue = daysUntilDue;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.CancelAt = cancelAt;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.Description = description;
            this.Discounts = discounts;
            this.AllowPromotionCode = allowPromotionCode;
            this.SubscriptionNotifyUrl = subscriptionNotifyUrl;
        }

            public string CustomerId { get; set; }
            public BillingTrialSettings TrialSettings { get; set; }
            public string PaymentBehavior { get; set; }
            public string CollectionMethod { get; set; }
            public int? DaysUntilDue { get; set; }
            public string BillingCycleAnchor { get; set; }
            public string CancelAt { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string Description { get; set; }
            public List<BillingSubscriptionDiscount> Discounts { get; set; }
            public bool? AllowPromotionCode { get; set; }
            public string SubscriptionNotifyUrl { get; set; }

        

    }

}
