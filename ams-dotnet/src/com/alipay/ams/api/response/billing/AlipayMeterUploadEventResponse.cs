using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayMeterUploadEventResponse : AMSResponse
    {

        public AlipayMeterUploadEventResponse() { }

        

        public AlipayMeterUploadEventResponse( Result result , int? retryAfter , List<Error> errors)
        {
            this.Result = result;
            this.RetryAfter = retryAfter;
            this.Errors = errors;
        }

            public Result Result { get; set; }
            public int? RetryAfter { get; set; }
            public List<Error> Errors { get; set; }

        

    }

}
