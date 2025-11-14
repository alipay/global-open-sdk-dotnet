using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipaySubscriptionUpdateResponse : AMSResponse
    {

        public AlipaySubscriptionUpdateResponse() { }

        

        public AlipaySubscriptionUpdateResponse( Result result)
        {
            this.Result = result;
        }

            public Result Result { get; set; }

        

    }

}
