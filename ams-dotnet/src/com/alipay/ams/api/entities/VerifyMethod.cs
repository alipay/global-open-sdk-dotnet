using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class VerifyMethod
    {

        public VerifyMethod() { }

        

        public VerifyMethod( string verifyMethodType , string otpValue)
        {
            this.VerifyMethodType = verifyMethodType;
            this.OtpValue = otpValue;
        }

            public string VerifyMethodType { get; set; }
            public string OtpValue { get; set; }

        

    }

}
