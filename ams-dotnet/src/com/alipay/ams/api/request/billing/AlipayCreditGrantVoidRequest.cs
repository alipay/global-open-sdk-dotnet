using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayCreditGrantVoidRequest : AMSRequest<AlipayCreditGrantVoidResponse>
    {

        public AlipayCreditGrantVoidRequest() { }

        

        public AlipayCreditGrantVoidRequest( string creditGrantId , string voidReason)
        {
            this.CreditGrantId = creditGrantId;
            this.VoidReason = voidReason;
        }

            public string CreditGrantId { get; set; }
            public string VoidReason { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/creditGrant/void"; } 


    }

}
