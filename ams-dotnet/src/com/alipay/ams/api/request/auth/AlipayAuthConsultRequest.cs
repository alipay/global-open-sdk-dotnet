using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;
using com.alipay.ams.api.response.auth;
using com.alipay.ams.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace com.alipay.ams.api.request.auth
{
    public class AlipayAuthConsultRequest : AMSRequest<AlipayAuthConsultResponse>
    {

        public CustomerBelongsTo CustomerBelongsTo { get; set; }


        public string AuthClientId { get; set; }


        public string AuthRedirectUrl { get; set; }


        public ScopeType[] Scopes { get; set; }


        public string AuthState { get; set; }


        public TerminalType TerminalType { get; set; }


        public OsType OsType { get; set; }


        public string OsVersion { get; set; }
        
        public string ExtendInfo { get; set; }
        
        public string MerchantRegion { get; set; }
        
        public bool? RecurringPayment { get; set; }

        public override string GetRequestURI()
        {
            return AntomPathConstants.AUTH_CONSULT_PATH;
        }

        public override void validate()
        {
            
        }
    }
}
