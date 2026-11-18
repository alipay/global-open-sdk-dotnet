using com.alipay.ams.api.response.notification;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.notification
{

public class AlipayInquireNotificationRequest : AMSRequest<AlipayInquireNotificationResponse>
    {

        public AlipayInquireNotificationRequest() { }

        

        public AlipayInquireNotificationRequest( string eventId)
        {
            this.EventId = eventId;
        }

            public string EventId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/notification/inquireNotification"; } 


    }

}
