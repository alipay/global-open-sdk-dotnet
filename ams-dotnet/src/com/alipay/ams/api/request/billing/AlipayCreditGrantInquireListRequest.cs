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

        

        public AlipayCreditGrantInquireListRequest( string customerId , string status)
        {
            this.CustomerId = customerId;
            this.Status = status;
        }

            public string CustomerId { get; set; }
            public string Status { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/creditGrant/inquireList"; } 


    }

}
