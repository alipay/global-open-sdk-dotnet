using System;
using System.Collections.Generic;

namespace com.alipay.ams.api.entities
{
    public class ErrorEvent
    {
        public string ErrorCode { get; set; }

        public string IdempotencyKey { get; set; }

        public long? EventTimestamp { get; set; }

        public EventPayload Payload { get; set; }
    }
}
