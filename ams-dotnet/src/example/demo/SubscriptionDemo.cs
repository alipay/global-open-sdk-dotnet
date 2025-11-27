using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request.subscription;

namespace ams_dotnet.demo;

public class SubscriptionDemo
{
    public static void SubscriptionsCreate(DefaultAlipayClient client)
    {
        var alipaySubscriptionCreateRequest = new AlipaySubscriptionCreateRequest();
        alipaySubscriptionCreateRequest.SubscriptionRequestId = "subscriptionRequestId"+(DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

        var env = new Env();
        env.ClientIp = "1.*.*.*";
        env.OsType = OsType.ANDROID;
        env.TerminalType = TerminalType.WEB;
        alipaySubscriptionCreateRequest.Env = env;

        alipaySubscriptionCreateRequest.PaymentAmount = new Amount("HKD", "10");

        alipaySubscriptionCreateRequest.PaymentNotificationUrl = "https://www.yourNotifyUrl.com";

        var periodRule = new PeriodRule();
        periodRule.PeriodType = PeriodType.MONTH;
        periodRule.PeriodCount = 1;

        alipaySubscriptionCreateRequest.PeriodRule = periodRule;

        var settlementStrategy = new SettlementStrategy();
        settlementStrategy.SettlementCurrency = "USD";

        alipaySubscriptionCreateRequest.SettlementStrategy = settlementStrategy;

        alipaySubscriptionCreateRequest.SubscriptionDescription = "test";
        alipaySubscriptionCreateRequest.SubscriptionStartTime = "2024-10-22T00:01:01+08:00";
        alipaySubscriptionCreateRequest.SubscriptionEndTime = "2024-10-23T00:01:01+08:00";
        alipaySubscriptionCreateRequest.SubscriptionExpiryTime = "2024-10-24T00:01:01+08:00";

        var orderInfo = new OrderInfo();
        orderInfo.OrderAmount = new Amount("HKD", "10");
        alipaySubscriptionCreateRequest.OrderInfo = orderInfo;

        var paymentMethod = new PaymentMethod(WalletPaymentMethodType.ALIPAY_HK.ToString());
        paymentMethod.RequireIssuerAuthentication = false;
        alipaySubscriptionCreateRequest.PaymentMethod = paymentMethod;

        alipaySubscriptionCreateRequest.SubscriptionRedirectUrl = "https://www.yourRedirectUrl.com";
        alipaySubscriptionCreateRequest.SubscriptionNotificationUrl = "https://www.yourNotifyUrl.com";
        
        var response = client.Execute(alipaySubscriptionCreateRequest);
        
        Console.WriteLine(response);
    }

    public static void SubscriptionsChange(DefaultAlipayClient client,string subscriptionId)
    {
        var alipaySubscriptionChangeRequest = new AlipaySubscriptionChangeRequest();
        alipaySubscriptionChangeRequest.SubscriptionId = subscriptionId;
        alipaySubscriptionChangeRequest.SubscriptionChangeRequestId = "subscriptionChangeRequestId"+(DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
        alipaySubscriptionChangeRequest.PaymentAmountDifference = new Amount("HKD", "100");
        alipaySubscriptionChangeRequest.PaymentAmount = new Amount("HKD", "100");
        
        
        var periodRule = new PeriodRule();
        periodRule.PeriodType = PeriodType.MONTH;
        periodRule.PeriodCount = 1;
        alipaySubscriptionChangeRequest.PeriodRule = periodRule;
        
        var orderInfo = new OrderInfo();
        orderInfo.OrderAmount = new Amount("HKD", "10");
        alipaySubscriptionChangeRequest.OrderInfo = orderInfo;
        
        
        alipaySubscriptionChangeRequest.SubscriptionStartTime = "2024-10-22T00:01:01+08:00";
        alipaySubscriptionChangeRequest.SubscriptionEndTime = "2024-10-23T00:01:01+08:00";
        
        var response = client.Execute(alipaySubscriptionChangeRequest);
        
        Console.WriteLine(response);
    }

    public static void subscriptionCancel(DefaultAlipayClient client, string subscriptionId)
    {
        
        var alipaySubscriptionCancelRequest = new AlipaySubscriptionCancelRequest();
        alipaySubscriptionCancelRequest.SubscriptionId = subscriptionId;
        alipaySubscriptionCancelRequest.CancellationType = CancellationType.CANCEL;
        
        var response = client.Execute(alipaySubscriptionCancelRequest);
        
        Console.WriteLine(response);  }
    
}