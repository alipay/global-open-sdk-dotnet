using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Statement
    {

        public Statement() { }

        

        public Statement( FundMoveDetail fundMoveDetail , ForeignExchangeQuote foreignExchangeQuote , string statementId , string transactionTime , string transactionType , Amount originalTransactionAmount , Amount transactionAmount , Amount feeAmount , Amount netAmount , Amount accountBalance , string transactionId , string extTransactionId , string transactionStatus , string beneficiaryAssetId)
        {
            this.FundMoveDetail = fundMoveDetail;
            this.ForeignExchangeQuote = foreignExchangeQuote;
            this.StatementId = statementId;
            this.TransactionTime = transactionTime;
            this.TransactionType = transactionType;
            this.OriginalTransactionAmount = originalTransactionAmount;
            this.TransactionAmount = transactionAmount;
            this.FeeAmount = feeAmount;
            this.NetAmount = netAmount;
            this.AccountBalance = accountBalance;
            this.TransactionId = transactionId;
            this.ExtTransactionId = extTransactionId;
            this.TransactionStatus = transactionStatus;
            this.BeneficiaryAssetId = beneficiaryAssetId;
        }

            public FundMoveDetail FundMoveDetail { get; set; }
            public ForeignExchangeQuote ForeignExchangeQuote { get; set; }
            public string StatementId { get; set; }
            public string TransactionTime { get; set; }
            public string TransactionType { get; set; }
            public Amount OriginalTransactionAmount { get; set; }
            public Amount TransactionAmount { get; set; }
            public Amount FeeAmount { get; set; }
            public Amount NetAmount { get; set; }
            public Amount AccountBalance { get; set; }
            public string TransactionId { get; set; }
            public string ExtTransactionId { get; set; }
            public string TransactionStatus { get; set; }
            public string BeneficiaryAssetId { get; set; }

        

    }

}
