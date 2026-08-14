using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireCardTransactionLifecycleResponse : AMSResponse
    {

        public AlipayInquireCardTransactionLifecycleResponse() { }

        

        public AlipayInquireCardTransactionLifecycleResponse( Result result , List<CardTransactionLifecycle> lifecycles , int? totalCount , int? totalPageNumber , int? currentPageNumber)
        {
            this.Result = result;
            this.Lifecycles = lifecycles;
            this.TotalCount = totalCount;
            this.TotalPageNumber = totalPageNumber;
            this.CurrentPageNumber = currentPageNumber;
        }

            public Result Result { get; set; }
            public List<CardTransactionLifecycle> Lifecycles { get; set; }
            public int? TotalCount { get; set; }
            public int? TotalPageNumber { get; set; }
            public int? CurrentPageNumber { get; set; }

        

    }

}
