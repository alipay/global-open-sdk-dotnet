using System.Collections.Generic;
using ams_dotnet.demo;
using ams_dotnet.example.tests;
using com.alipay.ams.api;

namespace ams_dotnet
{
    class Program
    {

        private const string GatewayUrl = "https://open-sea.alipay.com";
        private const string ClientId = "SANDBOX_5YC31G2ZNMQK07357";
        private const string MerchantPrivateKey =
            "MIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDhnOLYh3Tte5ELNzD6kr6TSN+F4oXaNlnKgx2aGf/xSSHIh1k+wihv6HbwPAexdtjpDQAgwEv4YXpdH3erQLuy3oBIBVsdbXWg09TRttyBeM8FzbMru6qR1TceypEPhR9W4/hP9DZEmn9XZmR7xR9KStDKJdnqSNr578IVFvp3hXUt2HfwoHbUwwOPbu8a66th9b1PyNJ5DOdSoTj52tvFMOyfCmKOn9U/bwtcT/EGEJFlIj1QjBSwlEeCBDUVwwKlo2ttMP5Omy7i4Lxi5NKAMdw+Cru49FqGEf9B/JKfovd6EcwrnUeDfXVltNrPJjdr19WzatDh0k0wE/9QT6EnAgMBAAECggEAZsbQdDFo69KRpZlT36I/3NqisNwbe+esidum/Y+Aj8tv72jxF+zc/PXaUOAX5RkuASSh/Ul8kj7dvlRacJJBr1868xQ1iLdXkZdOaOazluuQ66TkTTTlpB+MR6Oh538OYsfhU5L9sczr28XSWqvW8EIa0SvjFJ5x2tAFCxR3r0AqXFrRteHSPYI01sle9ynCq3frBQwX481N/T0YvDQNFiRw+YlzJwJsZqPooFA2H/o+AL+LQED7eevnLYvevNS4GGVkWNO7gfKFHJA3RCMJgRqsXfxs2SG2cBx6YBYCQ7JurP8veMr3NBf/OOGCZln4zY4Vl5bTXe5vxeT5gzm18QKBgQD/jCH38x0AIjx0zwpZyvcp6C/2PohVjb6B/TbAiMmaIjpei06DCXHrDiObTLoxguZfmA+ypiPTZBOwFEDo7wDJ8khQwRMx9ydPMiaWoFCvl5iSke2vs/ONxdw02zRGj2uivgqjDf+94eTS8aSTJ+7kt1KLq4ZQf80Efywv+0xVnwKBgQDiAy5MMU8oDiSun8FoSBX3SomjdOX/tg4hMZ2PKYnXTJFUJ5bkjLhgdsPO5WGcFGsdReuweTzKteIRmS0zvdekVIpWFchflyeIM3+OuI1ZJJG6t28Xg3e8VOXCD917fjLnOOmH3f7PV/rj59wVM0yPvGStlAbPP0kwrcci8Wo3eQKBgQDE/ujctGwhw0KppUVMbRtWEeiPQitlEGzQ1jtT9t661DH82hT/DNPlqLOoL2DFdCxVeup3BH5PojFPJn3XUw9fnkdDAWPju6xw768xpIouooV6T8ZUETvqiaG0mVrWHg+SmD+o7My+OxpjxuXgjwMpC201wFc9TRflpIeSwX1Z7wKBgQCpUgy7VC2jKoVctZ6ly2t5akQXSxqMKg4H3C3X9RypSVmPHGG1M59l1VP4imxIDBv7QEjEWu+qRfzphkIRA2asXBGPUJ5eztT0+u/TMnvijr0GjyoRCZMIaun+KviY7gCgrUh3W17sY1M4rpl44Ie5H0ClscIwPY9NgsMvcIFMsQKBgG/XoSq4KjB+/SFdLTH4ITLb6Q8rvWOOyu6OvTBCgfxhq4R+rBP/40bvd1Ax5Eawfwq/GDfUL5jpzoaJGXGXDI90eXdeDOHZB7rq/+un9De1jPLGc1Ty7YT3SctYAvFw8jo0K65eckL7AaiGHk39eOXrWmJVVchOVlkX8TayiTgk";
        private const string AlipayPublicKey =
            "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAq7zEydi4Q2VvUIb1Mjpm/I2R3NVWcSMddlhvHYJADZ07YOGjvlQPbH3iixhLMnk1Y0tT7Sw7B1Ov1kXDGUhnui/YmGQBDbz9vg4iPDXA8OU7TaSsIk2BbP4+uZoortx2AZu/ABTGBDvyhLyJBkNplJ7196Np+IMaxi2RlT2NEAV4vFIurUcfFl5vvMliyV1SacvIyONkurzixSLirlKBl35t1mGm44xqh7M40tcMScgdF8pIdkzVz0nAnBcGb0aTeD3YLQmYFFmbQhWIe7MAa0BPEK7sxTJ1x1PbRUCHEXiZURnPjZTD7FBsTfLlcGOlOe0DXB7mrWm+AP+fVBjbAwIDAQAB";



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
