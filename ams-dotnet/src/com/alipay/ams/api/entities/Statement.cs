using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Statement
    {

        public Statement() { }

        

        public Statement( string statementId , FundMoveDetail fundMoveDetail , string transactionType , string beneficiaryAssetId)
        {
            this.StatementId = statementId;
            this.FundMoveDetail = fundMoveDetail;
            this.TransactionType = transactionType;
            this.BeneficiaryAssetId = beneficiaryAssetId;
        }

            public string StatementId { get; set; }
            public FundMoveDetail FundMoveDetail { get; set; }
            public string TransactionType { get; set; }
            public string BeneficiaryAssetId { get; set; }

        

    }

}
