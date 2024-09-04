using System.Collections.Generic;
using ams_dotnet.demo;
using ams_dotnet.example.tests;
using com.alipay.ams.api;

namespace ams_dotnet
{
    class Program
    {
        private const string GatewayUrl = "https://open-sea-global.alipay.com";
        private const string ClientId = "SANDBOX_5YBZ1G2ZHUPS06086";

        // Below are fake keys that are for demo purpose. Replace them with your own ones.
        private const string MerchantPrivateKey = "MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQDvd0h55/WfbUrXfBkc0+X3H5RpD0b0T4yEVwnqUcFea7epULNstd5ItZXkV5UdkRiOqwUXGqTw2jLFbo/Qdgss+yXiUiIvB2ynncBNWNw9pCuzS+GUMw4ZARSwASPbb5hB0iK3ASl7BXOEncRuybm4gn3tD975hCGHpMeSTx0Z8rCHBqaterpyCPs68Op5kzoTYHiMCGozLeMUEand1O6OPZNQxM5c+ME+YaA6g4VbN6CjtxEihU/lhpruGN5yD+/zBRSdqrD0qxIyq3bxhTYzIXjImR4FBfqz5CoSwu7jFZdxTMyIW4lr/dXzqIvCcjrDP4R8aRB4Dy81vPTP0vnfAgMBAAECggEAIBW+az8OJP9S0M562ub1YAgmLXFzk1Z5QF4dIP01SH5sTE5YzA8OKnXSEJc/joebX7pAY1kZkn/Z36Qxtr+qPauk5s8Ub3KyNz8mvfZTBBtUE6DuJ5ozoFwJto9gi41HPEJ4jkaklSwkzzcIU8PJk5RAZRwERzBSAcetScg54PjmG424dn6fBE+0HTMtJc1l6WPzcJOm7F8X7VOpL7dZJBFQXFh/gagjz9a/WXb0BIeOyJ35PMh1Ta6ZMB1bmCRYHL/Z4JEp4OE1Wz6f20h1kLtEKr4EbN6DDylM5/f9rmpB+6THdNVuPVaKTm5g47mKDWt/XsT6qNrxAHYRpMH4qQKBgQD8bWXt4dz5Ao33Aohuv/PrLSNxnB7Q+v1fUmhza55n09jaNJOX95BzECBXHpxZxVnRnScHhPIAEjGcH8h5ahLTmbblBHzS9VivWqgDwsVFS/kS1iWLfqVAK2N1TM81X8kiwudfAN0h5SFzuiJrCqdu/X1QlBVs3hMO8MjN8u7xhQKBgQDy2uxCTs5ejC0TaY2WBcGZ+gmxLic+jOGHNqrcB2+dGyvF6yjZgeasdwG5hSO85z9KQP56Ar+JI03MUd6WJBDPs1zcd/FNN9HIFPmI4DM4RBrunr7QRq2yaKgA6k9WFh6G4EkO6DrD7A9xRNhGJgKpSOBpivdEY8yq8Ue0JcHpEwKBgBYgvOuyff1yJOG/XhhfSVGXXmEKL4VgSy+8+J0NlRBC+OJ/82RB9m6vvjYE3+3ap/oBDbfSBqjM735hJuDF1Kqp8ed3kj2n9kNA7jOOMl7VvxrQnO/yhSfv5cMVnaBvKiGa9k9Usw3SmTEc4wGBKJZJMGAM6yfk+8S2hNPQ9PNFAoGAM3tvXDsiim6C27ujlSsROJgF1/alwR/Sa3yOSeiVo6Nv6xwH49wiz2rHBdIQmmoXQ6F1kN3mRqciRe8RFZj9q1ollGMk1y6/HQA9SePlV8cwQmeKodJp3glLnC4PtXso64S+WBeo5YG0YFms02oZZFObpyQbePcDGzXc8naSndsCgYEAu35IqER+dxQNQxrgT83lzYDjtiEFTsyuyjKSvYNrhCJcgzNiGQSs55k1LEWuxNzvNuHaT3djcLINz9WrzZkShJBUZO50cTUcCjqw1C9fBGiqU7zQBvCb3rdNzAZwmEqjjjrT1dYH4gGdYc1dSc6XHwWWbduqbT91DaENxd4wIuY=";

        private const string AlipayPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAkJIL3C7NSzSQxP1DNK0Grktr5G5bMEj4ndEIBnSyFv8+e6ytS+G1+ch7EdZ4Lt7KYUGoFW1wJKyTS8V5UBMJTWxAkdc2uX3GrQiWbPvReMl3sNa3SC9Kmi8ofVKQdpAt8aZZaTLxmti0YyCh8zUTddE9AOeMZi8xvzC8chcGbfx4FA5meFGkPEBeYfxZgQzCjXnMJ/A2JFeh5g2443pfAq/caoIamcnTcA9qhJCMaqDyXb2pxXmg/VOClhqhaOjj4dnxzYKln1YNJw02SaVT9zjkNJkbY2QzCjEV0NdG/QLCQ/xBkFlDvlJ+nyCiTySqVOuJXGCos1cljMoYJGZLXQIDAQAB";
        static void Main(string[] args)
        {
            //PayDemo.alipay(new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey));
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
           List<string> ids = new List<string>() {"12343543543"};
           CustomsDemo.inquiryDeclaration(defaultAlipayClient,ids);
           
        }
    }
}
