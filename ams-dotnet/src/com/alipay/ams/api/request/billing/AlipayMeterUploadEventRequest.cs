using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayMeterUploadEventRequest : AMSRequest<AlipayMeterUploadEventResponse>
    {

        public AlipayMeterUploadEventRequest() { }

        

        public AlipayMeterUploadEventRequest( List<MeterEventBatch> meters)
        {
            this.Meters = meters;
        }

            public List<MeterEventBatch> Meters { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/uploadEvent"; } 


    }

}
