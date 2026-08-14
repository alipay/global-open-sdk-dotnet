using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireCardTransactionEventResponse : AMSResponse
    {

        public AlipayInquireCardTransactionEventResponse() { }

        

        public AlipayInquireCardTransactionEventResponse( Result result , List<CardTransactionEvent> events , int? totalCount , int? totalPageNumber , int? currentPageNumber)
        {
            this.Result = result;
            this.Events = events;
            this.TotalCount = totalCount;
            this.TotalPageNumber = totalPageNumber;
            this.CurrentPageNumber = currentPageNumber;
        }

            public new Result Result { get; set; }
            public List<CardTransactionEvent> Events { get; set; }
            public int? TotalCount { get; set; }
            public int? TotalPageNumber { get; set; }
            public int? CurrentPageNumber { get; set; }

        

    }

}
