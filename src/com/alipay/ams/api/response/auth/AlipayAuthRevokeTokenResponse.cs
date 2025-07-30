using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.auth
{

public class AlipayAuthRevokeTokenResponse : AMSResponse
    {

        public AlipayAuthRevokeTokenResponse() { }

        public AlipayAuthRevokeTokenResponse( Result result , string extendInfo)
        {
            this.Result = result;
            this.ExtendInfo = extendInfo;
        }

            public Result Result { get; set; }
            public string ExtendInfo { get; set; }

        

    }

}
