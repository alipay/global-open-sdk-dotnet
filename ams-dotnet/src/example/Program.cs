using System.Collections.Generic;
using ams_dotnet.demo;
using ams_dotnet.example.tests;
using com.alipay.ams.api;

namespace ams_dotnet
{
    class Program
    {

        private const string GatewayUrl = "";
        private const string ClientId = "";

        // Below are fake keys that are for demo purpose. Replace them with your own ones.
        private const string MerchantPrivateKey =  "";
        private const string AlipayPublicKey =  "";


        static void Main(string[] args)
        {
            PayDemo.alipay(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));
            PayDemo.query(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey),"PR20190000000001_1725381379719.623");
            PayDemo.cancel(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey),"PR20190000000001_1725381024794.669");
           PayDemo.refund(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey),"202409031940108001001889B0209199607");
           PayDemo.queryRefund(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey),"erf_PR20190000000001_5751725381493062.314");
           PayDemo.consult(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));
           PayDemo.createSession(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));

           var defaultAlipayClient = new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey);
           AuthDemo.authConsult(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));
           AuthDemo.applyTokenConsult(defaultAlipayClient,"281001139639787089651362");
           AuthDemo.revokeToken(defaultAlipayClient,"28288803001291161724296551000BgIrDiWzU0171000529");
           
           CustomsDemo.declare(defaultAlipayClient,"202408221940108001001887E0207467163");
           List<string> ids = new List<string>() {"12343543543"};
           CustomsDemo.inquiryDeclaration(defaultAlipayClient,ids);
           
           MarketplaceDemo.register(defaultAlipayClient);
          MarketplaceDemo.update(defaultAlipayClient,"mid_zhangtianren_ztr_20230807_180716_981");
          MarketplaceDemo.queryBalance(defaultAlipayClient,"mid_zhangtianren_ztr_20230807_180716_981");
          SubscriptionDemo.SubscriptionsCreate(defaultAlipayClient);
          SubscriptionDemo.SubscriptionsChange(defaultAlipayClient,"202410221900000000000001J0000010626");
          SubscriptionDemo.subscriptionCancel(defaultAlipayClient,"202410221900000000000001J0000010626");
          VaultingDemo.createVaultingSession(defaultAlipayClient);
          VaultingDemo.inquireVaulting(defaultAlipayClient,"vaultingRequestId26bc8b51-1617-455f-ab32-9572da9cb99d");
        }
        
    }
}
