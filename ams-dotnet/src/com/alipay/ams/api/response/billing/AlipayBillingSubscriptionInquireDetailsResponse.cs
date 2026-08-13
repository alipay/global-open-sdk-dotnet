using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayBillingSubscriptionInquireDetailsResponse : AMSResponse
    {

        public AlipayBillingSubscriptionInquireDetailsResponse() { }

        

        public AlipayBillingSubscriptionInquireDetailsResponse( ResultInfo result , string subscriptionId , string subscriptionRequestId , string createTime , string status , string billingMode , string paymentBehavior , string currentPeriodStart , string currentPeriodEnd , string billingCycleAnchor , bool? cancelAtPeriodEnd , string canceledAt , string trialStart , string trialEnd , BillingSubscriptionTrialSettings trialSettings , string cancelAt , string collectionMethod , int? daysUntilDue , BillingSubscriptionInquireDetailsCancellationDetails cancellationDetails , string terminationReason , string description , string defaultPaymentMethod , Amount subtotal , Amount discountAmount , Amount totalAmount , List<BillingSubscriptionPriceItem> priceItems , List<BillingSubscriptionDiscountInfo> discounts , string metadata)
        {
            this.Result = result;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionRequestId = subscriptionRequestId;
            this.CreateTime = createTime;
            this.Status = status;
            this.BillingMode = billingMode;
            this.PaymentBehavior = paymentBehavior;
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.BillingCycleAnchor = billingCycleAnchor;
            this.CancelAtPeriodEnd = cancelAtPeriodEnd;
            this.CanceledAt = canceledAt;
            this.TrialStart = trialStart;
            this.TrialEnd = trialEnd;
            this.TrialSettings = trialSettings;
            this.CancelAt = cancelAt;
            this.CollectionMethod = collectionMethod;
            this.DaysUntilDue = daysUntilDue;
            this.CancellationDetails = cancellationDetails;
            this.TerminationReason = terminationReason;
            this.Description = description;
            this.DefaultPaymentMethod = defaultPaymentMethod;
            this.Subtotal = subtotal;
            this.DiscountAmount = discountAmount;
            this.TotalAmount = totalAmount;
            this.PriceItems = priceItems;
            this.Discounts = discounts;
            this.Metadata = metadata;
        }

            public ResultInfo Result { get; set; }
            public string SubscriptionId { get; set; }
            public string SubscriptionRequestId { get; set; }
            public string CreateTime { get; set; }
            public string Status { get; set; }
            public string BillingMode { get; set; }
            public string PaymentBehavior { get; set; }
            public string CurrentPeriodStart { get; set; }
            public string CurrentPeriodEnd { get; set; }
            public string BillingCycleAnchor { get; set; }
            public bool? CancelAtPeriodEnd { get; set; }
            public string CanceledAt { get; set; }
            public string TrialStart { get; set; }
            public string TrialEnd { get; set; }
            public BillingSubscriptionTrialSettings TrialSettings { get; set; }
            public string CancelAt { get; set; }
            public string CollectionMethod { get; set; }
            public int? DaysUntilDue { get; set; }
            public BillingSubscriptionInquireDetailsCancellationDetails CancellationDetails { get; set; }
            public string TerminationReason { get; set; }
            public string Description { get; set; }
            public string DefaultPaymentMethod { get; set; }
            public Amount Subtotal { get; set; }
            public Amount DiscountAmount { get; set; }
            public Amount TotalAmount { get; set; }
            public List<BillingSubscriptionPriceItem> PriceItems { get; set; }
            public List<BillingSubscriptionDiscountInfo> Discounts { get; set; }
            public string Metadata { get; set; }

        

    }

}
