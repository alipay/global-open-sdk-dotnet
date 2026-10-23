using com.alipay.ams.api.response.notification;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.notification
{

public class AlipayInquireNotificationListRequest : AMSRequest<AlipayInquireNotificationListResponse>
    {

        public AlipayInquireNotificationListRequest() { }

        

        public AlipayInquireNotificationListRequest( List<string> notifyType , string eventCreateTimeFrom , string eventCreateTimeTo , int? limit , string startingAfter)
        {
            this.NotifyType = notifyType;
            this.EventCreateTimeFrom = eventCreateTimeFrom;
            this.EventCreateTimeTo = eventCreateTimeTo;
            this.Limit = limit;
            this.StartingAfter = startingAfter;
        }

            public List<string> NotifyType { get; set; }
            public string EventCreateTimeFrom { get; set; }
            public string EventCreateTimeTo { get; set; }
            public int? Limit { get; set; }
            public string StartingAfter { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/notification/inquireNotificationList"; } 


    }

}
