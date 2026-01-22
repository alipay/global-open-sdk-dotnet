using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundMoveDetail
    {

        public FundMoveDetail() { }

        

        public FundMoveDetail( string moveType , string sourceAccount , string targetAccount , string moveTime , string memo , string referenceTransactionId , string payerAssetId , string beneficiaryAssetId)
        {
            this.MoveType = moveType;
            this.SourceAccount = sourceAccount;
            this.TargetAccount = targetAccount;
            this.MoveTime = moveTime;
            this.Memo = memo;
            this.ReferenceTransactionId = referenceTransactionId;
            this.PayerAssetId = payerAssetId;
            this.BeneficiaryAssetId = beneficiaryAssetId;
        }

            public string MoveType { get; set; }
            public string SourceAccount { get; set; }
            public string TargetAccount { get; set; }
            public string MoveTime { get; set; }
            public string Memo { get; set; }
            public string ReferenceTransactionId { get; set; }
            public string PayerAssetId { get; set; }
            public string BeneficiaryAssetId { get; set; }

        

    }

}
