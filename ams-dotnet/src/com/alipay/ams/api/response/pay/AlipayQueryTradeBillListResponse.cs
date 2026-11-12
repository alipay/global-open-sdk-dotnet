using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayQueryTradeBillListResponse : AMSResponse
    {

        public AlipayQueryTradeBillListResponse() { }

        

        public AlipayQueryTradeBillListResponse( int? currentPage , int? pageSize , string timeZone , long? total , List<TradeBillQueryInfo> records , Result result)
        {
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.TimeZone = timeZone;
            this.Total = total;
            this.Records = records;
            this.Result = result;
        }

            public int? CurrentPage { get; set; }
            public int? PageSize { get; set; }
            public string TimeZone { get; set; }
            public long? Total { get; set; }
            public List<TradeBillQueryInfo> Records { get; set; }
            public Result Result { get; set; }

        

    }

}
