using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundMoveDetail
    {

        public FundMoveDetail() { }

        

        public FundMoveDetail( string memo , string referenceTransactionId , string payerAssetId , string beneficiaryAssetId)
        {
            this.Memo = memo;
            this.ReferenceTransactionId = referenceTransactionId;
            this.PayerAssetId = payerAssetId;
            this.BeneficiaryAssetId = beneficiaryAssetId;
        }

            public string Memo { get; set; }
            public string ReferenceTransactionId { get; set; }
            public string PayerAssetId { get; set; }
            public string BeneficiaryAssetId { get; set; }

        

    }

}
