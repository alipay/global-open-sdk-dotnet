using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardTransactionLifecycle
    {

        public CardTransactionLifecycle() { }

        

        public CardTransactionLifecycle( string lifecycleId , string latestEventType , string latestEventStatus , string lastUpdateTime , string transactionTime , Amount totalBillingAmount , Amount totalAuthAmount , Amount totalCancelAmount , Amount totalRefundAmount , Amount totalChargebackAmount , string assetId , string maskedCardNo)
        {
            this.LifecycleId = lifecycleId;
            this.LatestEventType = latestEventType;
            this.LatestEventStatus = latestEventStatus;
            this.LastUpdateTime = lastUpdateTime;
            this.TransactionTime = transactionTime;
            this.TotalBillingAmount = totalBillingAmount;
            this.TotalAuthAmount = totalAuthAmount;
            this.TotalCancelAmount = totalCancelAmount;
            this.TotalRefundAmount = totalRefundAmount;
            this.TotalChargebackAmount = totalChargebackAmount;
            this.AssetId = assetId;
            this.MaskedCardNo = maskedCardNo;
        }

            public string LifecycleId { get; set; }
            public string LatestEventType { get; set; }
            public string LatestEventStatus { get; set; }
            public string LastUpdateTime { get; set; }
            public string TransactionTime { get; set; }
            public Amount TotalBillingAmount { get; set; }
            public Amount TotalAuthAmount { get; set; }
            public Amount TotalCancelAmount { get; set; }
            public Amount TotalRefundAmount { get; set; }
            public Amount TotalChargebackAmount { get; set; }
            public string AssetId { get; set; }
            public string MaskedCardNo { get; set; }

        

    }

}
