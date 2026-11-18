using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayCreditGrantVoidResponse : AMSResponse
    {

        public AlipayCreditGrantVoidResponse() { }

        

        public AlipayCreditGrantVoidResponse( Result result , CreditGrant creditGrant)
        {
            this.Result = result;
            this.CreditGrant = creditGrant;
        }

            public Result Result { get; set; }
            public CreditGrant CreditGrant { get; set; }

        

    }

}
