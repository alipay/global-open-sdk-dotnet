using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class NotificationEvent
    {

        public NotificationEvent() { }

        

        public NotificationEvent( string eventId , string notifyType , string eventCreateTime , string deliveryStatus , string referenceMerchantId , Dictionary<string, Object> notificationData)
        {
            this.EventId = eventId;
            this.NotifyType = notifyType;
            this.EventCreateTime = eventCreateTime;
            this.DeliveryStatus = deliveryStatus;
            this.ReferenceMerchantId = referenceMerchantId;
            this.NotificationData = notificationData;
        }

            public string EventId { get; set; }
            public string NotifyType { get; set; }
            public string EventCreateTime { get; set; }
            public string DeliveryStatus { get; set; }
            public string ReferenceMerchantId { get; set; }
            public Dictionary<string, Object> NotificationData { get; set; }

        

    }

}
