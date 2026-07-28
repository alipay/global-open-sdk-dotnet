using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditGrantUpdateExpiryRequest : AMSRequest<AlipayCreditGrantUpdateExpiryResponse>
    {

        public AlipayCreditGrantUpdateExpiryRequest() { }

        

        public AlipayCreditGrantUpdateExpiryRequest( string creditGrantId , string expiryMode , string expiryDateTime)
        {
            this.CreditGrantId = creditGrantId;
            this.ExpiryMode = expiryMode;
            this.ExpiryDateTime = expiryDateTime;
        }

            public string CreditGrantId { get; set; }
            public string ExpiryMode { get; set; }
            public string ExpiryDateTime { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/creditGrant/updateExpiry"; } 


    }

}
