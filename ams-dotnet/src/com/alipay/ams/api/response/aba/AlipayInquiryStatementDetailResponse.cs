using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquiryStatementDetailResponse : AMSResponse
    {

        public AlipayInquiryStatementDetailResponse() { }

        

        public AlipayInquiryStatementDetailResponse( Result result , Statement statement , Dictionary<string, string> metadata)
        {
            this.Result = result;
            this.Statement = statement;
            this.Metadata = metadata;
        }

            public Result Result { get; set; }
            public Statement Statement { get; set; }
            public Dictionary<string, string> Metadata { get; set; }

        

    }

}
