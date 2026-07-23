using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Transaction
    {

        public Transaction() { }

        

        public Transaction( Result transactionResult , string transactionId , TransactionType transactionType , TransactionStatusType transactionStatus , Amount transactionAmount , string transactionRequestId , string transactionTime , AcquirerInfo acquirerInfo , Amount grossSettlementAmount , Quote settlementQuote)
        {
            this.TransactionResult = transactionResult;
            this.TransactionId = transactionId;
            this.TransactionType = transactionType;
            this.TransactionStatus = transactionStatus;
            this.TransactionAmount = transactionAmount;
            this.TransactionRequestId = transactionRequestId;
            this.TransactionTime = transactionTime;
            this.AcquirerInfo = acquirerInfo;
            this.GrossSettlementAmount = grossSettlementAmount;
            this.SettlementQuote = settlementQuote;
        }

            public Result TransactionResult { get; set; }
            public string TransactionId { get; set; }
            public TransactionType TransactionType { get; set; }
            public TransactionStatusType TransactionStatus { get; set; }
            public Amount TransactionAmount { get; set; }
            public string TransactionRequestId { get; set; }
            public string TransactionTime { get; set; }
            public AcquirerInfo AcquirerInfo { get; set; }
            public Amount GrossSettlementAmount { get; set; }
            public Quote SettlementQuote { get; set; }

        

    }

}
