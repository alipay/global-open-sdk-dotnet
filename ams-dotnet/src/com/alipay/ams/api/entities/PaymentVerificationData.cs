using System;
using System.Collections.Generic;
using System.Text;


namespace com.alipay.ams.api.entities
{
    public class PaymentVerificationData
    {

        public string VerifyRequestId
        {
            get; internal set;
        }

        public string AuthenticationCode { get; internal set; }

        public PaymentVerificationData(string verifyRequestId, string authenticationCode)
        {
            VerifyRequestId = verifyRequestId;
            AuthenticationCode = authenticationCode;
        }
    }
}
