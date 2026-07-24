using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayMeterCreateRequest : AMSRequest<AlipayMeterCreateResponse>
    {

        public AlipayMeterCreateRequest() { }

        

        public AlipayMeterCreateRequest( string meterName , string eventName , string aggregationMethod , string eventTimeWindow , string valueKeyOverride)
        {
            this.MeterName = meterName;
            this.EventName = eventName;
            this.AggregationMethod = aggregationMethod;
            this.EventTimeWindow = eventTimeWindow;
            this.ValueKeyOverride = valueKeyOverride;
        }

            public string MeterName { get; set; }
            public string EventName { get; set; }
            public string AggregationMethod { get; set; }
            public string EventTimeWindow { get; set; }
            public string ValueKeyOverride { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/create"; } 


    }

}
