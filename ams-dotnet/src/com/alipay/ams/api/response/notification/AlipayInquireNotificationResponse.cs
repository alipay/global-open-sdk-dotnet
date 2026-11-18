using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.notification
{

public class AlipayInquireNotificationResponse : AMSResponse
    {

        public AlipayInquireNotificationResponse() { }

        

        public AlipayInquireNotificationResponse( Result result , NotificationEvent notification)
        {
            this.Result = result;
            this.Notification = notification;
        }

            public Result Result { get; set; }
            public NotificationEvent Notification { get; set; }

        

    }

}
