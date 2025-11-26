using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquiryStatementListResponse : AMSResponse
    {

        public AlipayInquiryStatementListResponse() { }

        

        public AlipayInquiryStatementListResponse( List<Statement> statementList , Result result)
        {
            this.StatementList = statementList;
            this.Result = result;
        }

            public List<Statement> StatementList { get; set; }
            public Result Result { get; set; }

        

    }

}
