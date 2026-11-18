using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquiryStatementDetailRequest : AMSRequest<AlipayInquiryStatementDetailResponse>
    {

        public AlipayInquiryStatementDetailRequest() { }

        

        public AlipayInquiryStatementDetailRequest( string statementId)
        {
            this.StatementId = statementId;
        }

            public string StatementId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/accounts/inquiryStatementDetail"; } 


    }

}
