using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayBillingSubscriptionCreateRequest : AMSRequest<AlipayBillingSubscriptionCreateResponse>
    {

        public AlipayBillingSubscriptionCreateRequest() { }

        

        public AlipayBillingSubscriptionCreateRequest( string subscriptionRequestId , string customerId , string customerEmail , List<PriceItem> priceItems , BillingSubscriptionCreateTrialSettings trialSettings , List<Discount> discounts , string paymentBehavior , string collectionMethod , int? daysUntilDue , string billingCycleAnchor , string cancelAt , bool? cancelAtPeriodEnd , string description , string subscriptionNotifyUrl , Dictionary<string, string> metadata)
        {
            this.SubscriptionRequestId = subscriptionRequestId;
            this.CustomerId = customerId;
            this.CustomerEmail = customerEmail;
            this.PriceItems = priceItems;
            this.TrialSettings = trialSettings;
            this.Discounts = discounts;
            this.PaymentBehavior = paymentBehavior;
            this.CollectionMethod = collectionMethod;
            this.DaysUntilDue = daysUntilDue;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.CancelAt = cancelAt;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.Description = description;
            this.SubscriptionNotifyUrl = subscriptionNotifyUrl;
            this.Metadata = metadata;
        }

            public string SubscriptionRequestId { get; set; }
            public string CustomerId { get; set; }
            public string CustomerEmail { get; set; }
            public List<PriceItem> PriceItems { get; set; }
            public BillingSubscriptionCreateTrialSettings TrialSettings { get; set; }
            public List<Discount> Discounts { get; set; }
            public string PaymentBehavior { get; set; }
            public string CollectionMethod { get; set; }
            public int? DaysUntilDue { get; set; }
            public string BillingCycleAnchor { get; set; }
            public string CancelAt { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string Description { get; set; }
            public string SubscriptionNotifyUrl { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/subscription/create"; } 


    }

}
