using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.vaulting;

namespace ams_dotnet.demo;

public class VaultingDemo
{
    public static void createVaultingSession(DefaultAlipayClient client)
    {
        var alipayVaultingSessionRequest = new AlipayVaultingSessionRequest();
        alipayVaultingSessionRequest.VaultingRequestId = "vaultingRequestId" + Guid.NewGuid();
        alipayVaultingSessionRequest.PaymentMethodType = "CARD";
        alipayVaultingSessionRequest.VaultingNotificationUrl = "https://www.yourNotifyUrl.com";
        alipayVaultingSessionRequest.RedirectUrl = "https://www.yourRedirectUrl.com";
        alipayVaultingSessionRequest.MerchantRegion = "BR";
        
        var response = client.Execute(alipayVaultingSessionRequest);
        
        Console.WriteLine(response);
    }

    public static void vaultPaymentMethod(DefaultAlipayClient client)
    {
        var alipayVaultingPaymentMethodRequest = new AlipayVaultingPaymentMethodRequest();
        alipayVaultingPaymentMethodRequest.VaultingRequestId = "vaultingRequestId" + Guid.NewGuid();

        alipayVaultingPaymentMethodRequest.VaultingNotificationUrl = "https://www.yourNotifyUrl.com";
        alipayVaultingPaymentMethodRequest.RedirectUrl = "https://www.yourRedirectUrl.com";
        alipayVaultingPaymentMethodRequest.MerchantRegion = "BR";

        var paymentMethodDetail = new PaymentMethodDetail();
        paymentMethodDetail.PaymentMethodType = "CARD";
        var cardPaymentMethodDetail = new CardPaymentMethodDetail();
        cardPaymentMethodDetail.CardNo = "4111111111111111";
        cardPaymentMethodDetail.Brand = CardBrand.VISA;
        var billingAddress = new Address();
        billingAddress.Region = "BR";
        billingAddress.Address1 = "address1";
        billingAddress.Address2 = "address2";
        cardPaymentMethodDetail.BillingAddress = billingAddress;
        var userName = new UserName();
        userName.FullName = "fullName";
        userName.FirstName = "firstName";
        userName.LastName = "lastName";
        cardPaymentMethodDetail.CardholderName = userName;
        cardPaymentMethodDetail.ExpiryYear = "2026";
        cardPaymentMethodDetail.ExpiryMonth = "06";
        cardPaymentMethodDetail.Cvv = "123";
        paymentMethodDetail.Card = cardPaymentMethodDetail;

        alipayVaultingPaymentMethodRequest.PaymentMethodDetail = paymentMethodDetail;

        var env = new Env();
        env.TerminalType = TerminalType.APP;
        alipayVaultingPaymentMethodRequest.Env = env;

        var response = client.Execute(alipayVaultingPaymentMethodRequest);
        
        Console.WriteLine(response);
    }

    public static void inquireVaulting(DefaultAlipayClient client,string vaultingRequestId)
    {
        var alipayVaultingQueryRequest = new AlipayVaultingQueryRequest();
        alipayVaultingQueryRequest.VaultingRequestId = vaultingRequestId;
        
        var response = client.Execute(alipayVaultingQueryRequest);
        
        Console.WriteLine(response);
    }
}