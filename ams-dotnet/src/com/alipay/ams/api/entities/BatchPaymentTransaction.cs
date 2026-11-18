using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BatchPaymentTransaction
    {

        public BatchPaymentTransaction() { }

        

        public BatchPaymentTransaction( Result transactionResult , string transactionId , string transactionType , string transactionStatus , Amount transactionAmount , string transactionRequestId)
        {
            this.TransactionResult = transactionResult;
            this.TransactionId = transactionId;
            this.TransactionType = transactionType;
            this.TransactionStatus = transactionStatus;
            this.TransactionAmount = transactionAmount;
            this.TransactionRequestId = transactionRequestId;
        }

            public Result TransactionResult { get; set; }
            public string TransactionId { get; set; }
            public string TransactionType { get; set; }
            public string TransactionStatus { get; set; }
            public Amount TransactionAmount { get; set; }
            public string TransactionRequestId { get; set; }

        

    }

}
