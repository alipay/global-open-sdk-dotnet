using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCreditGrantInquireListResponse : AMSResponse
    {

        public AlipayCreditGrantInquireListResponse() { }

        

        public AlipayCreditGrantInquireListResponse( Result result , CreditGrant creditGrants)
        {
            this.Result = result;
            this.CreditGrants = creditGrants;
        }

            public Result Result { get; set; }
            public CreditGrant CreditGrants { get; set; }

        

    }

}
