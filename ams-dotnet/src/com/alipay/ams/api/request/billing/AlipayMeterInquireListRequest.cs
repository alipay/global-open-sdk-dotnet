using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayMeterInquireListRequest : AMSRequest<AlipayMeterInquireListResponse>
    {

        public AlipayMeterInquireListRequest() { }

        

        public AlipayMeterInquireListRequest( int? pageNum , int? pageSize , string meterName , string eventName , string status , string startDateTime , string endDateTime)
        {
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.MeterName = meterName;
            this.EventName = eventName;
            this.Status = status;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
        }

            public int? PageNum { get; set; }
            public int? PageSize { get; set; }
            public string MeterName { get; set; }
            public string EventName { get; set; }
            public string Status { get; set; }
            public string StartDateTime { get; set; }
            public string EndDateTime { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/meter/inquireList"; } 


    }

}
