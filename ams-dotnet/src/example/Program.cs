using System;
using System.Text.Json;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;

namespace ams_dotnet
{
    class Program
    {
        private const string GatewayUrl = "https://open-sea.alipay.com";
        private const string ClientId = "your_client_id_here";

        // Below are fake keys that are for demo purpose. Replace them with your own ones.
        private const string MerchantPrivateKey = "MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCKw/v9T90FXjfIrfyVPMflMfmuVdAZxjV8TKlhIy9ONmw5lOIfl4C8qIZ8AnjIzDOaWcNo5mlsUyHvAKZ81tozMPIWqFwJvK3NVm70dp9vfrgkOgdUm5zSNnrq1M3KItkZ41Yip0STtSPfeT/4WR38xUINKDH/nDwGF14Y7tRMbYU6G9q8X0NRQsa3M16QoSNm6YDQDzcW+nSETb+pks0D5yWOjXrZ39RHp1z38yT+IA/orYZdDsO2D9RKUs6DayWliYledChtndLntMR5ktQY4sw13cyrqinlkn/3lUGLvOXIfoVFOeYJNYWCyIzBpdsKPt0nLGBTQIvY13KUpI85AgMBAAECggEAd+meQysVasMdX4yCPZB1iOijw3QiTXOL2qsAn5FhGqxK34N52CT6uYzEEjuslpBnc1VoWKjrpxE7vKYKOM0NZ7k/Kjc4ua1TX6L2ZMhxRE7z31JJ7WI/pSQxGeblImz0wLtEPtPenemlY0MK9ZhFIp5vUqFOe31OHVFqHg+cY6HhuOkIWTOXW3gCxLuPET+ekEKbsx8bGZiAc9Qh/GJzPWlaVggXMPx3KBt1Nmjd1faymjELWxuJk4NB4XM4fwYMopEbTFOc0e+SeAtOs/VpYZ47hPLj9fXqM/JmPdRbbvQYg6vpvgEy4aRswRX2SUjLJ/g2BmS40PkpQyR1cQLgxQKBgQDhqtErYlf+fDzVS3lcj0qeL52BgamA16oKTXSGnMc9pYNzh4kZgMeE4g2iEfNzPcCL0mfB6L+B9XV2XVNC53rnHxoX/11CG58cM7AI6ks4yl8rJngPl9HCt/wq5yNEhSfCoU2RN8N1la66koHWVJeXTerQUmyI9fKzIVGjpFslSwKBgQCdauP+0pTX2eT79qA6shIiE5zSLlS5Nsk6x+mS4C1wxEVBsy5cDes6bKm7CN5IkGfLbpHdXqYNnVczt1rf2CyHaH+Sb4s600+VytoI5HAP5kXEjGfF7KsMv9ujHaRVrCxr9D/p7ELV7c8nBRyZeN8bQvzEXOTW2JQDvXM6JlW/CwKBgBA33IyHptdNSnnx0KkMS0qPFXzHOs1dsoTHCEbcYZ1Wldnptbq1fKFaNayeKabwmzPxTS+scIcAgw6cqm02gai2nYN4ANXNcmPuewpI/Fr6gFhzjVFhkduyqVbUAb7c6vyb5x02qr96oHIcMWSb88EWAngyVEaLloO1M07Vcw99AoGAUNGjMp4M2vE8tfu98cSguKwXFHXC+8Bb+fjPO6Aq1D2ATSXgRFTFEx7c2XDJJro0/+XJr7y7RjwknCGj307ONcr5zEXGVrJMptwZqv0VZ6RS54EqehxzCT2rVwiN6YpW2CnzcnbhLZJFi4P9VfIPoaB3w5zpxEA3ZeArO4yY81cCgYEAuiHiqj5zp6oC8rOXxYSHZ+F3BGw3KCQRU8bOxtW1SZNJSgx65LGro7qpL2KPsvvIpr9xeE25mqMut9PeLgJHSAiK40lWnCpXMeD088PBkbKVaa6ub2vj74hxJHmexqvTJRWeIuWFrhAUGxbzHeVShxwhSiurSzLsLZtG+BEJa2w=";
        private const string AlipayPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAhJ5vPPThv5qFZ/3/nOcjJifbq9da9Yu1Xp3wSfJq2vFo0STtws6WGg1t34709Tcg7k4H4rgUnpvBX6h6gjGrFpZLt/uu7Q+cxnWjduvjXy4kanYp5pfSuZvblGR+LPB/yVQo0dh1iDAHk17GT1GuJ0MsBVGykU2Ji+PGkAFeYpaLiLl+uBtOEK8XVyxX7DSW8QNgQpaHBHrBBESqScV2O+ZyII6tVBlYBy/1QPkFDlJHSRTCQngak5HF0WSNYrPLFSMIgrmGDBfO2PFjuqStBNjL7+x9mRSzNF+3LY+uP/XemKmSTtRU5bSM99SNCHW5VGQvJuWX9P17686yRKKYOwIDAQAB";

        static void Main(string[] args)
        {
            var client = new DefaultAlipayClient(GatewayUrl, ClientId, MerchantPrivateKey, AlipayPublicKey);

            string paymentId = testInstorePayment(client);

            //testQuery(client);

            //testCancel(client);

            //testCashierPayment(client);

            //testRefund(client, paymentId);
        }

        private static string testInstorePayment(DefaultAlipayClient client)
        {
            var request = new UserPresentedCodePaymentRequest("288888888888888888");


            long amountInCents = 1000;
            request.PaymentAmount = new Amount("JPY", amountInCents);
            Order order = new Order();
            order.OrderAmount = new Amount("JPY", amountInCents);
            order.OrderDescription = "New White Lace Sleeveless";
            order.ReferenceOrderId = "0000000001";
            order.Merchant = new Merchant("Some_Mer", "seller231117459", "7011", new Store(
                "Some_store", "store231117459", "7011"));

            order.Env = new Env();
            order.Env.StoreTerminalId = "some_setStoreTerminalId";
            order.Env.StoreTerminalRequestTime = "2020-06-11T13:35:02+08:00";

            string paymentRequestId = "PR20190000000001_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

            request.PaymentRequestId = paymentRequestId;
            request.Order = order;

            Console.WriteLine(request);

            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");

            Console.WriteLine(response);

            return response.PaymentId;
        }

        private static void testQuery(DefaultAlipayClient client)
        {
            PaymentInquiryRequest paymentInquiryRequest = new PaymentInquiryRequest();
            paymentInquiryRequest.PaymentRequestId = "PR20190000000001_575";

            PaymentInquiryResponse paymentInquiryResponse = client.Execute(paymentInquiryRequest);

            Console.WriteLine("paymentInquiryResponse: \n" + paymentInquiryResponse);
        }

        private static void testCancel(DefaultAlipayClient client)
        {
            PaymentCancelRequest paymentCancelRequest = new PaymentCancelRequest();
            paymentCancelRequest.PaymentRequestId = "PR20190000000001_575";

            PaymentCancelResponse paymentCancelResponse = client.Execute(paymentCancelRequest);

            Console.WriteLine("paymentCancelResponse: \n" + paymentCancelResponse);
        }

        private static void testRefund(DefaultAlipayClient client, string paymentId)
        {
            PaymentRefundRequest paymentRefundRequest = new PaymentRefundRequest();
            paymentRefundRequest.PaymentId = paymentId;
            paymentRefundRequest.RefundRequestId = "erf_PR20190000000001_575" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            paymentRefundRequest.RefundAmount = new Amount("JPY", 1000);
            paymentRefundRequest.RefundRequestTime = DateTime.UtcNow.ToString("o");

            PaymentRefundResponse paymentRefundResponse = client.Execute(paymentRefundRequest);

            Console.WriteLine("paymentRefundResponse: \n" + paymentRefundResponse);
        }

        private static string testCashierPayment(DefaultAlipayClient client)
        {
            var request = new CommonPaymentRequest<CommonPaymentResponse>();

            request.ProductCode = ProductCodeType.CASHIER_PAYMENT;
            request.PaymentAmount = new Amount("PHP", 300);
            request.PaymentMethod = new PaymentMethod(WalletPaymentMethodType.GCASH.ToString());
            request.PaymentNotifyUrl = "http://alipay.com";
            request.PaymentRedirectUrl = "http://alipay.com";

            long amountInCents = 1000;
            Order order = new Order();
            order.OrderAmount = new Amount("PHP", amountInCents);
            order.OrderDescription = "New White Lace Sleeveless";
            order.ReferenceOrderId = "0000000001";
            order.Merchant = new Merchant("Some_Mer", "seller231117459", "7011", new Store(
                "Some_store", "store231117459", "7011"));

            order.Env = new Env();
            order.Env.StoreTerminalId = "some_setStoreTerminalId";
            order.Env.StoreTerminalRequestTime = "2020-06-11T13:35:02+08:00";

            string paymentRequestId = "PR20190000000001_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

            request.PaymentRequestId = paymentRequestId;
            request.Order = order;

            Console.WriteLine(request);

            CommonPaymentResponse response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.PaymentId;
        }
    }
}
