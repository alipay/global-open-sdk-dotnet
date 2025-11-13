using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PaymentVerificationData
    {

        public PaymentVerificationData() { }

        

        public PaymentVerificationData(  string  verifyRequestId ,  string  authenticationCode)
        {
            this.VerifyRequestId = verifyRequestId;
            this.AuthenticationCode = authenticationCode;
        }

            public  string  VerifyRequestId { get; set; }
            public  string  AuthenticationCode { get; set; }

        

    }

}
