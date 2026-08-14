using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardTransactionEvent
    {

        public CardTransactionEvent() { }

        

        public CardTransactionEvent( string eventId , string lifecycleId , string eventType , string authExpireTime , string authType , string authCode , string failureReason , string status , string balanceType , string transactionTime , string billType , Amount outAmount , Amount inAmount , string exchangeCurrencyPair , string exchangeRate , Amount transactionAmount , string assetId , string maskedCardNo , EventMerchantInfo merchantInfo , Dictionary<string, string> metadata)
        {
            this.EventId = eventId;
            this.LifecycleId = lifecycleId;
            this.EventType = eventType;
            this.AuthExpireTime = authExpireTime;
            this.AuthType = authType;
            this.AuthCode = authCode;
            this.FailureReason = failureReason;
            this.Status = status;
            this.BalanceType = balanceType;
            this.TransactionTime = transactionTime;
            this.BillType = billType;
            this.OutAmount = outAmount;
            this.InAmount = inAmount;
            this.ExchangeCurrencyPair = exchangeCurrencyPair;
            this.ExchangeRate = exchangeRate;
            this.TransactionAmount = transactionAmount;
            this.AssetId = assetId;
            this.MaskedCardNo = maskedCardNo;
            this.MerchantInfo = merchantInfo;
            this.Metadata = metadata;
        }

            public string EventId { get; set; }
            public string LifecycleId { get; set; }
            public string EventType { get; set; }
            public string AuthExpireTime { get; set; }
            public string AuthType { get; set; }
            public string AuthCode { get; set; }
            public string FailureReason { get; set; }
            public string Status { get; set; }
            public string BalanceType { get; set; }
            public string TransactionTime { get; set; }
            public string BillType { get; set; }
            public Amount OutAmount { get; set; }
            public Amount InAmount { get; set; }
            public string ExchangeCurrencyPair { get; set; }
            public string ExchangeRate { get; set; }
            public Amount TransactionAmount { get; set; }
            public string AssetId { get; set; }
            public string MaskedCardNo { get; set; }
            public EventMerchantInfo MerchantInfo { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        

    }

}
