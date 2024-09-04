using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.auth;

namespace ams_dotnet.demo;

public class AuthDemo
{
    public static void authConsult(DefaultAlipayClient client)
    {
        var alipayAuthConsultRequest = new AlipayAuthConsultRequest();
        alipayAuthConsultRequest.AuthRedirectUrl = "https://www.alipay.com";
        alipayAuthConsultRequest.AuthState = "123456";
        alipayAuthConsultRequest.CustomerBelongsTo = CustomerBelongsTo.ALIPAY_CN;
        alipayAuthConsultRequest.OsType = OsType.ANDROID;
        alipayAuthConsultRequest.OsVersion = "1.0.0";
        alipayAuthConsultRequest.Scopes = new[] { ScopeType.AGREEMENT_PAY };
        alipayAuthConsultRequest.TerminalType = TerminalType.APP;
        
        var response = client.Execute(alipayAuthConsultRequest);

        Console.WriteLine("\n============================================================\n");
        Console.WriteLine(response);
    }

    public static void applyTokenConsult(DefaultAlipayClient client, string authCode)
    {
        var alipayAuthApplyTokenRequest = new AlipayAuthApplyTokenRequest();
        alipayAuthApplyTokenRequest.GrantType = GrantType.AUTHORIZATION_CODE;
        alipayAuthApplyTokenRequest.CustomerBelongsTo = CustomerBelongsTo.ALIPAY_CN;
        alipayAuthApplyTokenRequest.AuthCode = authCode;
        var response = client.Execute(alipayAuthApplyTokenRequest);

        Console.WriteLine("\n============================================================\n");
        Console.WriteLine(response);
    }

    public static void revokeToken(DefaultAlipayClient client, string accessToken)
    {
        var alipayAuthRevokeTokenRequest = new AlipayAuthRevokeTokenRequest();
        alipayAuthRevokeTokenRequest.AccessToken = accessToken;
        var response = client.Execute(alipayAuthRevokeTokenRequest);

        Console.WriteLine("\n============================================================\n");
        Console.WriteLine(response);
    }
    
}