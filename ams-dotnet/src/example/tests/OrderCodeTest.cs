using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;

namespace ams_dotnet.example.tests
{
    public class OrderCodeTest
    {

        public static void run(DefaultAlipayClient client, string currency)
        {
            string paymentRequestId = "PR20190000000001_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

            string paymentId = testOrderCode(client, paymentRequestId, currency);

        }

        private static string testOrderCode(DefaultAlipayClient client, string paymentRequestId, string currency)
        {
            
            var request = new OrderCodePaymentRequest();


            long amountInCents = 1000;
            request.PaymentAmount = new Amount(currency, amountInCents);
            request.PaymentNotifyUrl = "https://www.yourNotifyUrl.com";
            Order order = new Order();
            order.OrderAmount = new Amount(currency, amountInCents);
            order.OrderDescription = "New White Lace Sleeveless";
            order.ReferenceOrderId = "0000000001";
            order.Merchant = new Merchant("Some_Mer", "seller231117459", "7011", new Store(
                "Some_store", "store231117459", "7011"));

            order.Env = new Env();
            order.Env.StoreTerminalId = "some_setStoreTerminalId";
            order.Env.StoreTerminalRequestTime = "2020-06-11T13:35:02+08:00";

            
            request.PaymentRequestId = paymentRequestId;
            request.Order = order;

            Console.WriteLine(request);

            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");

            Console.WriteLine(response);

            return response.PaymentId;
        }
    }
}
