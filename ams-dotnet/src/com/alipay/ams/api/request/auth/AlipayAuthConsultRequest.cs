using com.alipay.ams.api.response.auth;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.auth
{

public class AlipayAuthConsultRequest : AMSRequest<AlipayAuthConsultResponse>
    {

        public AlipayAuthConsultRequest() { }

        

        public AlipayAuthConsultRequest(  CustomerBelongsTo  customerBelongsTo ,  string  authClientId ,  string  authRedirectUrl ,  List<ScopeType>  scopes ,  string  authState ,  TerminalType  terminalType ,  OsType  osType ,  string  osVersion ,  string  extendInfo ,  string  merchantRegion ,  bool?  recurringPayment ,  AuthMetaData  authMetaData)
        {
            this.CustomerBelongsTo = customerBelongsTo;
            this.AuthClientId = authClientId;
            this.AuthRedirectUrl = authRedirectUrl;
            this.Scopes = scopes;
            this.AuthState = authState;
            this.TerminalType = terminalType;
            this.OsType = osType;
            this.OsVersion = osVersion;
            this.ExtendInfo = extendInfo;
            this.MerchantRegion = merchantRegion;
            this.RecurringPayment = recurringPayment;
            this.AuthMetaData = authMetaData;
        }

            public  CustomerBelongsTo  CustomerBelongsTo { get; set; }
            public  string  AuthClientId { get; set; }
            public  string  AuthRedirectUrl { get; set; }
            public  List<ScopeType>  Scopes { get; set; }
            public  string  AuthState { get; set; }
            public  TerminalType  TerminalType { get; set; }
            public  OsType  OsType { get; set; }
            public  string  OsVersion { get; set; }
            public  string  ExtendInfo { get; set; }
            public  string  MerchantRegion { get; set; }
            public  bool?  RecurringPayment { get; set; }
            public  AuthMetaData  AuthMetaData { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/authorizations/consult"; } 


    }

}
