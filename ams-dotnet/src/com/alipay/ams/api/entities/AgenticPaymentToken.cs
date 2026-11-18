using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AgenticPaymentToken
    {

        public AgenticPaymentToken() { }

        

        public AgenticPaymentToken( string token , string tokenExpirationYear , string tokenExpirationMonth , string tokenExpiration , string status , string dynamicDataType , string dynamicDataValue)
        {
            this.Token = token;
            this.TokenExpirationYear = tokenExpirationYear;
            this.TokenExpirationMonth = tokenExpirationMonth;
            this.TokenExpiration = tokenExpiration;
            this.Status = status;
            this.DynamicDataType = dynamicDataType;
            this.DynamicDataValue = dynamicDataValue;
        }

            public string Token { get; set; }
            public string TokenExpirationYear { get; set; }
            public string TokenExpirationMonth { get; set; }
            public string TokenExpiration { get; set; }
            public string Status { get; set; }
            public string DynamicDataType { get; set; }
            public string DynamicDataValue { get; set; }

        

    }

}
