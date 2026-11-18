using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Error
    {

        public Error() { }

        

        public Error( int? index , int? groupIndex , string eventName , string idempotencyKey , string customerId , string errorCode)
        {
            this.Index = index;
            this.GroupIndex = groupIndex;
            this.EventName = eventName;
            this.IdempotencyKey = idempotencyKey;
            this.CustomerId = customerId;
            this.ErrorCode = errorCode;
        }

            public int? Index { get; set; }
            public int? GroupIndex { get; set; }
            public string EventName { get; set; }
            public string IdempotencyKey { get; set; }
            public string CustomerId { get; set; }
            public string ErrorCode { get; set; }

        

    }

}
