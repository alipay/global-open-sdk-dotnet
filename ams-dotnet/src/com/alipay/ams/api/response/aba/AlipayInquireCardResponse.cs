using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireCardResponse : AMSResponse
    {

        public AlipayInquireCardResponse() { }

        

        public AlipayInquireCardResponse( Result result , int? totalCount , int? totalPageNumber , int? currentPageNumber , List<Card> cardList)
        {
            this.Result = result;
            this.TotalCount = totalCount;
            this.TotalPageNumber = totalPageNumber;
            this.CurrentPageNumber = currentPageNumber;
            this.CardList = cardList;
        }

            public Result Result { get; set; }
            public int? TotalCount { get; set; }
            public int? TotalPageNumber { get; set; }
            public int? CurrentPageNumber { get; set; }
            public List<Card> CardList { get; set; }

        

    }

}
