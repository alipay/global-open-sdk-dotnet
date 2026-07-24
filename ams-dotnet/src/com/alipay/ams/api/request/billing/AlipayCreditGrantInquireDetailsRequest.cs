using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditGrantInquireDetailsRequest : AMSRequest<AlipayCreditGrantInquireDetailsResponse>
    {

        public AlipayCreditGrantInquireDetailsRequest() { }

        

        public AlipayCreditGrantInquireDetailsRequest( string creditGrantId)
        {
            this.CreditGrantId = creditGrantId;
        }

            public string CreditGrantId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/creditGrant/inquireDetails"; } 


    }

}
