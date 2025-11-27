using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Statement
    {

        public Statement() { }

        

        public Statement( string statementId , FundMoveDetail fundMoveDetail)
        {
            this.StatementId = statementId;
            this.FundMoveDetail = fundMoveDetail;
        }

            public string StatementId { get; set; }
            public FundMoveDetail FundMoveDetail { get; set; }

        

    }

}
