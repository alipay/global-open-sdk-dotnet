using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipaySubscriptionCreateResponse : AMSResponse
    {

        public AlipaySubscriptionCreateResponse() { }

        

        public AlipaySubscriptionCreateResponse( Result result , string schemeUrl , string applinkUrl , string normalUrl , string appIdentifier)
        {
            this.Result = result;
            this.SchemeUrl = schemeUrl;
            this.ApplinkUrl = applinkUrl;
            this.NormalUrl = normalUrl;
            this.AppIdentifier = appIdentifier;
        }

            public Result Result { get; set; }
            public string SchemeUrl { get; set; }
            public string ApplinkUrl { get; set; }
            public string NormalUrl { get; set; }
            public string AppIdentifier { get; set; }

        

    }

}
