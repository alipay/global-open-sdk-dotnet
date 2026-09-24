using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayCreateMandateResponse : AMSResponse
    {

        public AlipayCreateMandateResponse() { }

        

        public AlipayCreateMandateResponse( Result result , string mandateRequestId , string mandateId , string validFrom , string validUntil)
        {
            this.Result = result;
            this.MandateRequestId = mandateRequestId;
            this.MandateId = mandateId;
            this.ValidFrom = validFrom;
            this.ValidUntil = validUntil;
        }

            public Result Result { get; set; }
            public string MandateRequestId { get; set; }
            public string MandateId { get; set; }
            public string ValidFrom { get; set; }
            public string ValidUntil { get; set; }

        

    }

}
