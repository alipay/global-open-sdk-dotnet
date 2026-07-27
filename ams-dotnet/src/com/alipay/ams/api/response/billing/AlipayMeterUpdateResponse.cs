using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayMeterUpdateResponse : AMSResponse
    {

        public AlipayMeterUpdateResponse() { }

        

        public AlipayMeterUpdateResponse( Result result , Meter meter)
        {
            this.Result = result;
            this.Meter = meter;
        }

            public Result Result { get; set; }
            public Meter Meter { get; set; }

        

    }

}
