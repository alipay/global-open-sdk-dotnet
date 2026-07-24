using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayMeterUpdateRequest : AMSRequest<AlipayMeterUpdateResponse>
    {

        public AlipayMeterUpdateRequest() { }

        

        public AlipayMeterUpdateRequest( string meterId , string meterName , string status)
        {
            this.MeterId = meterId;
            this.MeterName = meterName;
            this.Status = status;
        }

            public string MeterId { get; set; }
            public string MeterName { get; set; }
            public string Status { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/update"; } 


    }

}
