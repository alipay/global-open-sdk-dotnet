using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class PaymentVerificationData
    {
        [JsonPropertyNameAttribute("verifyRequestId")]
        public string VerifyRequestId
        {
            get; internal set;
        }
        [JsonPropertyNameAttribute("authenticationCode")]
        public string AuthenticationCode { get; internal set; }

        public PaymentVerificationData(string verifyRequestId, string authenticationCode)
        {
            VerifyRequestId = verifyRequestId;
            AuthenticationCode = authenticationCode;
        }
    }
}
