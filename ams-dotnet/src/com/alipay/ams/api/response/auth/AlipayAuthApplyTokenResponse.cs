using System;
using System.Collections.Generic;
using System.Text;


namespace com.alipay.ams.api.response.auth
{
    public class AlipayAuthApplyTokenResponse : AMSResponse
    {

        public String AccessToken { get; set; }

        public String AccessTokenExpiryTime { get; set; }

        public String RefreshToken { get; set; }

        public String RefreshTokenExpiryTime { get; set; }
    }
}
