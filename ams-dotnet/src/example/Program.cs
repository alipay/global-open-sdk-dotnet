using System.Collections.Generic;
using ams_dotnet.demo;
using ams_dotnet.example.tests;
using com.alipay.ams.api;

namespace ams_dotnet
{
    class Program
    {

        private const string GatewayUrl = "https://open-na-global.alipay.com";
        private const string ClientId = "SANDBOX_5YES502ZS7KG03623";

        // Below are fake keys that are for demo purpose. Replace them with your own ones.
        private const string MerchantPrivateKey = "MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQC9tC4d3Wnf65KfcyjKXfbPUwO/OT6p4VhRaY8VxETG7WWAVWPYwECPNprsK/Waoce2ItVHzWzy/+3avs0jOkUudXH9CoDqDX/DqGAPbW3MdFU1+aVfkO96rC/Dyfqm6m0+WgqKXCIC1ohxKuYC+0n6nDBTwbfuoUTCXtWA9jxvmfkWJ2jJSQKegePdXX1t0GrGMEzAoAMur0/k/pu6ys9cCRMa90A5yr3rMQNdeE/5u97Qpn8oQYfWkYF73vK8lUx4cNlaQUBvNue5HNcdNV5Cx40+RNj7W3KfqmAIKV3PWYwrwvuJOXkVdP4h/vch4rHFTSovclnTJmlpnVdPe7qRAgMBAAECggEABeBE5WvsUaFMY1//zXTnpjheD1hIlp6CS9NHOVdhAgBsenMqqpYZ6dW5KsOZ0fZc50lg7d5xF33R8kqitAqkBfJhW4MtxxIv+PGIODIdio237foTo0gsAtK+kAP7nZv5UksbtHlyHEBk7Yx0n3cFLZwU6yM+/UdFh/fECUCXUqWWnq39Ub8onxK5KGN4tQDxV9lZQtlAd8ecbQ1yC8sYNtNCLQD+IcGuPooqEXb6bIq1yFdXKItrWr0zt/UAn2Q3CqbFZPnQgxm2k9lrKLhwEtkSF3MuKLZ2v/6AO+P7Nf4fzQwADoUjcoRrq/2m68a9csUJm1gOcI1bSnJE/nLhIQKBgQDtoKi3APMIzauqN0dEUZG9GDmy1E0O2zdRLc1sfw9jI33739xCM4Qi1L1pS8Tq9/GKXy5AjTp6OCemvYvNvWTiBIXU51BTsvtr55DMRKJz86mOZInHak02CKKlDFUL3Imw40R//+I9TwkqPJsdyAFPvrLHOLjED9CC7RnwfkTkrQKBgQDMXviD6ZFz3ARaC2YJojdSBmd0UWX0895eeWpMliJTg4SouhNIVX7ZnBMtqafOfn6fuTW48fgvZVejHA75D7rUBbkSmuQgUweRT+h6j3tb5YvX8Yfq/a6223m0H96Fp/zG9UmhTaq4qnEZtU1JaEysPUXYs2zwO2qaFuzmGJuF9QKBgBbpabsTdVuA8S9dWxrEPqgb4NxUSgXHr0K9htQSQDqP3oLdp9AeRXxSRN0VOCxrsbdkzAHfXCcSqQgTuJoiy8pbI0hO8VjQphtWXYjEiWFiuhOHsB0xK7atCHmfgce+AOy0TROGaZr9tuWCqHYrpay5t2UsG+yTlcg58klU83GVAoGATUPGftCqHfxbZNOUYyYB9i/XowE3I7GjK2KJzqSgG6TIXaXjrmAsUgcQtR3EBGyMYMR7zA0nAHw28sKj4oOQ5aG4Q5Ftl87sOILWaKegQrD4+s4kzbHVAOrfCztVPICzL2EC0knztlcx5T9HFe6ptiCALJpBIF3GQrVSIPfCrJUCgYAG5vUql6cXg9WqLLGYoBlYfsXxyDR3iygHHElYXk4j43Utki9EBK+sKyLeZGJtQPq0+QW0VsgcUhAjaT/eMQPKfm9mmwKr+ZK4S83SKBmqF5PWIifKd2HGmXbuowH1TzDgwwLrqEcyt9WM9u/1+XeFOwlDISFTMYXkXHDQ8kNcKg==";

        private const string AlipayPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAlrcFqfGF1W/0HyvzAeV1MsipDAWM3yt+PFSVmwbxtiHfk0o27ubA8pyyo3N7j/u/PrDhDi5Aq6d5f0oDfLNSEY1C/PBU0/LruObAp7fOTDiIdkL44h4q71pw1sPOLb7bPLXtAhlzWRyGxV7IDDPkXpXC14BBAtPJUK0ICMDPyMJBNI6qUq5jK33N67XcnlnPQQETbb3pwBqgvK7u00RBZPGpyo2HW+n0hRHN/kd9E/M6UO3H0RoJsEa9o14QPVQOdILopL7eXr/6Y7BHoz78itpSozn7jFi+tc+iYxrJLUKIcrIdOVMx72kNcpBEMoaMl74gFlOwKFAUUM0cL7Lc4wIDAQAB";



        static void Main(string[] args)
        {
            PayDemo.alipay(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));
            //PayDemo.query(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey),"PR20190000000001_1725381379719.623");
           // PayDemo.cancel(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey),"PR20190000000001_1725381024794.669");
           //PayDemo.refund(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey),"202409031940108001001889B0209199607");
           //PayDemo.queryRefund(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey),"erf_PR20190000000001_5751725381493062.314");
           //PayDemo.consult(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));
           //PayDemo.createSession(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));

           var defaultAlipayClient = new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey);
           //AuthDemo.authConsult(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));
           //AuthDemo.applyTokenConsult(defaultAlipayClient,"281001139639787089651362");
           //AuthDemo.revokeToken(defaultAlipayClient,"28288803001291161724296551000BgIrDiWzU0171000529");
           
           //CustomsDemo.declare(defaultAlipayClient,"202408221940108001001887E0207467163");
           //List<string> ids = new List<string>() {"12343543543"};
           //CustomsDemo.inquiryDeclaration(defaultAlipayClient,ids);
           
          // MarketplaceDemo.register(defaultAlipayClient);
          //MarketplaceDemo.update(defaultAlipayClient,"mid_zhangtianren_ztr_20230807_180716_981");
          // MarketplaceDemo.queryBalance(defaultAlipayClient,"mid_zhangtianren_ztr_20230807_180716_981");
          //SubscriptionDemo.SubscriptionsCreate(defaultAlipayClient);
          //SubscriptionDemo.SubscriptionsChange(defaultAlipayClient,"202410221900000000000001J0000010626");
          //SubscriptionDemo.subscriptionCancel(defaultAlipayClient,"202410221900000000000001J0000010626");
          //VaultingDemo.createVaultingSession(defaultAlipayClient);
          //VaultingDemo.inquireVaulting(defaultAlipayClient,"vaultingRequestId26bc8b51-1617-455f-ab32-9572da9cb99d");
        }
        
    }
}
