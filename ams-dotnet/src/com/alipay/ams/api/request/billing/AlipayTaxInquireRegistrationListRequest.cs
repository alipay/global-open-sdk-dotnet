using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayTaxInquireRegistrationListRequest : AMSRequest<AlipayTaxInquireRegistrationListResponse>
    {

        public AlipayTaxInquireRegistrationListRequest() { }

        

        public AlipayTaxInquireRegistrationListRequest( string status , int? currentPage , int? pageSize)
        {
            this.Status = status;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
        }

            public string Status { get; set; }
            public int? CurrentPage { get; set; }
            public int? PageSize { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/tax/inquireRegistrationList"; } 


    }

}
