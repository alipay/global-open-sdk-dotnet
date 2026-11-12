using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayQueryTradeBillListRequest : AMSRequest<AlipayQueryTradeBillListResponse>
    {

        public AlipayQueryTradeBillListRequest() { }

        

        public AlipayQueryTradeBillListRequest( string merchantId , int? currentPage , int? pageSize , long? startTimestamp , long? endTimestamp , string timeZone)
        {
            this.MerchantId = merchantId;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.TimeZone = timeZone;
        }

            public string MerchantId { get; set; }
            public int? CurrentPage { get; set; }
            public int? PageSize { get; set; }
            public long? StartTimestamp { get; set; }
            public long? EndTimestamp { get; set; }
            public string TimeZone { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/adaptor/queryTradeBillList"; } 


    }

}
