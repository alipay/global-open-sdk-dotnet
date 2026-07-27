using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayMeterInquireListResponse : AMSResponse
    {

        public AlipayMeterInquireListResponse() { }

        

        public AlipayMeterInquireListResponse( Result result , List<Meter> meters)
        {
            this.Result = result;
            this.Meters = meters;
        }

            public Result Result { get; set; }
            public List<Meter> Meters { get; set; }

        

    }

}
