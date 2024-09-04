using System;
using System.Collections.Generic;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.customs;

namespace ams_dotnet.demo;

public class CustomsDemo
{
    public static void declare(DefaultAlipayClient client, string paymentId)
    {
        var alipayCustomsDeclareRequest = new AlipayCustomsDeclareRequest();
        alipayCustomsDeclareRequest.PaymentId = paymentId;
        alipayCustomsDeclareRequest.DeclarationAmount = new Amount("CNY", 10000);
        var merchantCustomsInfo = new MerchantCustomsInfo();
        merchantCustomsInfo.MerchantCustomsName = "merchantCustomsName";
        merchantCustomsInfo.MerchantCustomsCode = "merchantCustomsCode";
        alipayCustomsDeclareRequest.MerchantCustomsInfo = merchantCustomsInfo;
        alipayCustomsDeclareRequest.SplitOrder = false;
        var customsInfo = new CustomsInfo();
        customsInfo.Region = "CN";
        customsInfo.CustomsCode = "ZHENGZHOU";
        alipayCustomsDeclareRequest.Customs = customsInfo;
        var certificate = new Certificate();
        certificate.CertificateNo = "certificateNo";
        certificate.CertificateType = CertificateType.ID_CARD;
        var userName = new UserName();
        userName.FirstName = "firstName";
        userName.LastName = "lastName";
        userName.FullName = "fullName";
        certificate.HolderName = userName;
        alipayCustomsDeclareRequest.BuyerCertificate =certificate;
        
        var response = client.Execute(alipayCustomsDeclareRequest);

        Console.WriteLine("\n============================================================\n");
        Console.WriteLine(response);
    }

    public static void inquiryDeclaration(DefaultAlipayClient client, List<string> declareRequestIds)
    {
        var alipayCustomsQueryRequest = new AlipayCustomsQueryRequest();
        alipayCustomsQueryRequest.DeclarationRequestIds = declareRequestIds;
        var response = client.Execute(alipayCustomsQueryRequest);

        Console.WriteLine("\n============================================================\n");
        Console.WriteLine(response);
    }
}