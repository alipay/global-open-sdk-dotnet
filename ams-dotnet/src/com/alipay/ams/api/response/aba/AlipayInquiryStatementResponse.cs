using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquiryStatementResponse : AMSResponse
    {

        public AlipayInquiryStatementResponse() { }

        

        public AlipayInquiryStatementResponse( List<Statement> statementList , ResultResult result , int? totalCount , int? totalPageNumber , int? currentPageNumber)
        {
            this.StatementList = statementList;
            this.Result = result;
            this.TotalCount = totalCount;
            this.TotalPageNumber = totalPageNumber;
            this.CurrentPageNumber = currentPageNumber;
        }

            public List<Statement> StatementList { get; set; }
            public ResultResult Result { get; set; }
            public int? TotalCount { get; set; }
            public int? TotalPageNumber { get; set; }
            public int? CurrentPageNumber { get; set; }

        

    }

}
