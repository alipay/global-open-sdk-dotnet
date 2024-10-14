using System;
using System.Collections.Generic;
using System.Text;
using com.alipay.ams.api.entities;


namespace com.alipay.ams.api.response.auth
{
    public class AlipayAuthApplyTokenResponse : AMSResponse
    {

        public string AccessToken { get; set; }

        public string AccessTokenExpiryTime { get; set; }

        public string RefreshToken { get; set; }

        public string RefreshTokenExpiryTime { get; set; }
        
        public string ExtendInfo { get; set; }
        public string UserLoginId { get; set; }
        public PspCustomerInfo PspCustomerInfo { get; set; }
    }
}
