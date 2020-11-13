using System;


namespace com.alipay.ams.api.response.auth
{
    public class AlipayUserQueryInfoResponse : AMSResponse
    {

        public String UserId { get; set; }


        public String UserLoginId { get; set; }


        public String HashUserLoginId { get; set; }
    }
}
