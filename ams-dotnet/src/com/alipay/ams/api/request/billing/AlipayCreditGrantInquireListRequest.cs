using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditGrantInquireListRequest : AMSRequest<AlipayCreditGrantInquireListResponse>
    {

        public AlipayCreditGrantInquireListRequest() { }

        

        public AlipayCreditGrantInquireListRequest( int? pageNum , int? pageSize , string customerId , string status)
        {
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.CustomerId = customerId;
            this.Status = status;
        }

            public int? PageNum { get; set; }
            public int? PageSize { get; set; }
            public string CustomerId { get; set; }
            public string Status { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/creditGrant/inquireList"; } 


    }

}
