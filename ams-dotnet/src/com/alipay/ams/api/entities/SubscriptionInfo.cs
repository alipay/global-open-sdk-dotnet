using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class SubscriptionInfo
    {

        public SubscriptionInfo() { }

        

        public SubscriptionInfo( string subscriptionId , string description , string subscriptionDescription , SubscriptionStatus status , string subscriptionStartTime , string subscriptionEndTime , PeriodType periodType , int? periodCount , PeriodRule periodRule , string currentPeriodStart , string currentPeriodEnd , int? currentPhaseNo , PaymentMethod paymentMethod , Amount paymentAmount , string lastUpdateTime , string relatedSubscriptionId , TrialPlan trialPlan , List<Trial> trials , string subscriptionNotifyUrl , string subscriptionExpiryTime , bool? allowRetry , Amount maxAmountFloor)
        {
            this.SubscriptionId = subscriptionId;
            this.Description = description;
            this.SubscriptionDescription = subscriptionDescription;
            this.Status = status;
            this.SubscriptionStartTime = subscriptionStartTime;
            this.SubscriptionEndTime = subscriptionEndTime;
            this.PeriodType = periodType;
            this.PeriodCount = periodCount;
            this.PeriodRule = periodRule;
            this.CurrentPeriodStart = currentPeriodStart;
            this.CurrentPeriodEnd = currentPeriodEnd;
            this.CurrentPhaseNo = currentPhaseNo;
            this.PaymentMethod = paymentMethod;
            this.PaymentAmount = paymentAmount;
            this.LastUpdateTime = lastUpdateTime;
            this.RelatedSubscriptionId = relatedSubscriptionId;
            this.TrialPlan = trialPlan;
            this.Trials = trials;
            this.SubscriptionNotifyUrl = subscriptionNotifyUrl;
            this.SubscriptionExpiryTime = subscriptionExpiryTime;
            this.AllowRetry = allowRetry;
            this.MaxAmountFloor = maxAmountFloor;
        }

            public string SubscriptionId { get; set; }
            public string Description { get; set; }
            public string SubscriptionDescription { get; set; }
            public SubscriptionStatus Status { get; set; }
            public string SubscriptionStartTime { get; set; }
            public string SubscriptionEndTime { get; set; }
            public PeriodType PeriodType { get; set; }
            public int? PeriodCount { get; set; }
            public PeriodRule PeriodRule { get; set; }
            public string CurrentPeriodStart { get; set; }
            public string CurrentPeriodEnd { get; set; }
            public int? CurrentPhaseNo { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public Amount PaymentAmount { get; set; }
            public string LastUpdateTime { get; set; }
            public string RelatedSubscriptionId { get; set; }
            public TrialPlan TrialPlan { get; set; }
            public List<Trial> Trials { get; set; }
            public string SubscriptionNotifyUrl { get; set; }
            public string SubscriptionExpiryTime { get; set; }
            public bool? AllowRetry { get; set; }
            public Amount MaxAmountFloor { get; set; }

        

    }

}
