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

        

        public AlipayBillingSubscriptionCreateRequest( string subscriptionRequestId , string customerId , string customerEmail , List<PriceItem> priceItems , BillingTrialSettings trialSettings , List<BillingDiscount> discounts , string paymentBehavior , string collectionMethod , int? daysUntilDue , string cancelAt , bool? cancelAtPeriodEnd , string description , string subscriptionNotifyUrl , string metadata)
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
            public BillingTrialSettings TrialSettings { get; set; }
            public List<BillingDiscount> Discounts { get; set; }
            public string PaymentBehavior { get; set; }
            public string CollectionMethod { get; set; }
            public int? DaysUntilDue { get; set; }
            public string CancelAt { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string Description { get; set; }
            public string SubscriptionNotifyUrl { get; set; }
            public string Metadata { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/subscription/create"; } 


    }

}
