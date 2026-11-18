using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.notification
{

public class AlipayInquireNotificationListResponse : AMSResponse
    {

        public AlipayInquireNotificationListResponse() { }

        

        public AlipayInquireNotificationListResponse( Result result , List<NotificationEvent> notifications , bool? hasMore , string nextStartingAfter)
        {
            this.Result = result;
            this.Notifications = notifications;
            this.HasMore = hasMore;
            this.NextStartingAfter = nextStartingAfter;
        }

            public Result Result { get; set; }
            public List<NotificationEvent> Notifications { get; set; }
            public bool? HasMore { get; set; }
            public string NextStartingAfter { get; set; }

        

    }

}
