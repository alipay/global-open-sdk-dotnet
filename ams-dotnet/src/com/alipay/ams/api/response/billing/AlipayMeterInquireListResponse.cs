using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayMeterInquireListResponse : AMSResponse
    {

        public AlipayMeterInquireListResponse() { }

        

        public AlipayMeterInquireListResponse( Result result , int? pageNum , int? pageSize , int? totalCount , List<Meter> meters)
        {
            this.Result = result;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
            this.Meters = meters;
        }

            public Result Result { get; set; }
            public int? PageNum { get; set; }
            public int? PageSize { get; set; }
            public int? TotalCount { get; set; }
            public List<Meter> Meters { get; set; }

        

    }

}
