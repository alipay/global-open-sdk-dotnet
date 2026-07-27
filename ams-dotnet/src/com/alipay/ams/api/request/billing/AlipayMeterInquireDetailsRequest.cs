using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayMeterInquireDetailsRequest : AMSRequest<AlipayMeterInquireDetailsResponse>
    {

        public AlipayMeterInquireDetailsRequest() { }

        

        public AlipayMeterInquireDetailsRequest( string meterId)
        {
            this.MeterId = meterId;
        }

            public string MeterId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/inquireDetails"; } 


    }

}
