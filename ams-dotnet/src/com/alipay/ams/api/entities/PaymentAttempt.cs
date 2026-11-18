using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentAttempt
    {

        public PaymentAttempt() { }

        

        public PaymentAttempt( string attemptAt , string attemptResponse)
        {
            this.AttemptAt = attemptAt;
            this.AttemptResponse = attemptResponse;
        }

            public string AttemptAt { get; set; }
            public string AttemptResponse { get; set; }

        

    }

}
