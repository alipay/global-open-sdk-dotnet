using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCreditNoteInquireListResponse : AMSResponse
    {

        public AlipayCreditNoteInquireListResponse() { }

        

        public AlipayCreditNoteInquireListResponse( Result result , bool? hasMore , int? totalCount , List<CreditNoteSummary> list)
        {
            this.Result = result;
            this.HasMore = hasMore;
            this.TotalCount = totalCount;
            this.List = list;
        }

            public Result Result { get; set; }
            public bool? HasMore { get; set; }
            public int? TotalCount { get; set; }
            public List<CreditNoteSummary> List { get; set; }

        

    }

}
