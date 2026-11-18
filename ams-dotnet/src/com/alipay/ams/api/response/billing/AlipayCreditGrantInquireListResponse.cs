using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCreditGrantInquireListResponse : AMSResponse
    {

        public AlipayCreditGrantInquireListResponse() { }

        

        public AlipayCreditGrantInquireListResponse( Result result , int? pageNum , int? pageSize , int? totalCount , List<CreditGrant> creditGrants)
        {
            this.Result = result;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
            this.CreditGrants = creditGrants;
        }

            public Result Result { get; set; }
            public int? PageNum { get; set; }
            public int? PageSize { get; set; }
            public int? TotalCount { get; set; }
            public List<CreditGrant> CreditGrants { get; set; }

        

    }

}
