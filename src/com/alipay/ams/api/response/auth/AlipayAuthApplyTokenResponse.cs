using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.auth
{

public class AlipayAuthApplyTokenResponse : AMSResponse
    {

        public AlipayAuthApplyTokenResponse() { }

        public AlipayAuthApplyTokenResponse( Result result , string accessToken , string accessTokenExpiryTime , string refreshToken , string refreshTokenExpiryTime , string extendInfo , string userLoginId , PspCustomerInfo pspCustomerInfo)
        {
            this.Result = result;
            this.AccessToken = accessToken;
            this.AccessTokenExpiryTime = accessTokenExpiryTime;
            this.RefreshToken = refreshToken;
            this.RefreshTokenExpiryTime = refreshTokenExpiryTime;
            this.ExtendInfo = extendInfo;
            this.UserLoginId = userLoginId;
            this.PspCustomerInfo = pspCustomerInfo;
        }

            public Result Result { get; set; }
            public string AccessToken { get; set; }
            public string AccessTokenExpiryTime { get; set; }
            public string RefreshToken { get; set; }
            public string RefreshTokenExpiryTime { get; set; }
            public string ExtendInfo { get; set; }
            public string UserLoginId { get; set; }
            public PspCustomerInfo PspCustomerInfo { get; set; }

        

    }

}
