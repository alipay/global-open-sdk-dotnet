using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundMoveDetail
    {

        public FundMoveDetail() { }

        

        public FundMoveDetail( string memo , string referenceTransactionId)
        {
            this.Memo = memo;
            this.ReferenceTransactionId = referenceTransactionId;
        }

            public string Memo { get; set; }
            public string ReferenceTransactionId { get; set; }

        

    }

}
