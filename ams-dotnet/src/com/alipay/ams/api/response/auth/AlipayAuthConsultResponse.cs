using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.auth
{

public class AlipayAuthConsultResponse : AMSResponse
    {

        public AlipayAuthConsultResponse() { }

        

        public AlipayAuthConsultResponse(  Result  result ,  string  authUrl ,  string  extendInfo ,  string  normalUrl ,  string  schemeUrl ,  string  applinkUrl ,  string  appIdentifier ,  AuthCodeForm  authCodeForm)
        {
            this.Result = result;
            this.AuthUrl = authUrl;
            this.ExtendInfo = extendInfo;
            this.NormalUrl = normalUrl;
            this.SchemeUrl = schemeUrl;
            this.ApplinkUrl = applinkUrl;
            this.AppIdentifier = appIdentifier;
            this.AuthCodeForm = authCodeForm;
        }

            public  Result  Result { get; set; }
            public  string  AuthUrl { get; set; }
            public  string  ExtendInfo { get; set; }
            public  string  NormalUrl { get; set; }
            public  string  SchemeUrl { get; set; }
            public  string  ApplinkUrl { get; set; }
            public  string  AppIdentifier { get; set; }
            public  AuthCodeForm  AuthCodeForm { get; set; }

        

    }

}
