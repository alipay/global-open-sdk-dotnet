using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCustomerInquireListRequest : AMSRequest<AlipayCustomerInquireListResponse>
    {

        public AlipayCustomerInquireListRequest() { }

        

        public AlipayCustomerInquireListRequest( string startingAfter , string endingBefore , int? limit , bool? includeTotal , string status , string email , string mobileNo)
        {
            this.StartingAfter = startingAfter;
            this.EndingBefore = endingBefore;
            this.Limit = limit;
            this.IncludeTotal = includeTotal;
            this.Status = status;
            this.Email = email;
            this.MobileNo = mobileNo;
        }

            public string StartingAfter { get; set; }
            public string EndingBefore { get; set; }
            public int? Limit { get; set; }
            public bool? IncludeTotal { get; set; }
            public string Status { get; set; }
            public string Email { get; set; }
            public string MobileNo { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/customer/inquireList"; } 


    }

}
