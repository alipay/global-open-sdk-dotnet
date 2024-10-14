using com.alipay.ams.api.response;
using System;
using System.Collections.Generic;
using System.Text;
using com.alipay.ams.api.entities;


namespace com.alipay.ams.api.response.auth
{
    public class AlipayAuthConsultResponse : AMSResponse
    {

        public string AuthUrl { get; set; }
        
        public string ExtendInfo { get; set; }
        public string NormalUrl { get; set; }
        public string SchemeUrl { get; set; }
        public string ApplinkUrl { get; set; }
        public string AppIdentifier  { get; set; }
        public AuthCodeForm AuthCodeForm { get; set; }
    }
}
