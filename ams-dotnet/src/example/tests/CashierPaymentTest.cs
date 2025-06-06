﻿using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;

namespace ams_dotnet.example.tests
{
    public class CashierPaymentTest
    {
        //RequestURIs of Cashier Payments APIs in sandbox are different from what are in production.

        class SandboxCommonPaymentRequest : CommonPaymentRequest<CommonPaymentResponse>
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/payments/pay";
            }

        }


        class SandboxPaymentCreateRequest : PaymentCreateRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/payments/create";
            }

        }



        class SandboxPaymentInquiryRequest : PaymentInquiryRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/payments/inquiryPayment";
            }

        }

        class SandboxPaymentCancelRequest : PaymentCancelRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/payments/cancel";
            }

        }

        class SandboxPaymentRefundRequest : PaymentRefundRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/payments/refund";
            }

        }

        public static void run(DefaultAlipayClient client, string currency)
        {
            string paymentRequestId = "PR20190000000001_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

            //string paymentId = testCashierPayment(client, paymentRequestId, currency);

            //testQuery(client, paymentRequestId);

            //testRefund(client, paymentId, currency);

            //testCancel(client, paymentRequestId);

            testCashierPaymentCreate(client, paymentRequestId, currency);

        }

        private static string testCashierPayment(DefaultAlipayClient client, string paymentRequestId, string currency)
        {
            var request = new SandboxCommonPaymentRequest();

            request.ProductCode = ProductCodeType.CASHIER_PAYMENT;
            request.PaymentAmount = new Amount(currency, 300);
            request.PaymentMethod = new PaymentMethod(WalletPaymentMethodType.GCASH.ToString());
            request.PaymentNotifyUrl = "https://www.yourNotifyUrl.com";
            request.PaymentRedirectUrl = "https://www.yourRedirectUrl.com";

            long amountInCents = 1000;
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

            CommonPaymentResponse response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.PaymentId;
        }

        private static string testCashierPaymentCreate(DefaultAlipayClient client, string paymentRequestId, string currency)
        {
            var request = new SandboxPaymentCreateRequest();

            request.ProductCode = ProductCodeType.CASHIER_PAYMENT;
            request.PaymentAmount = new Amount(currency, 3000);
            request.PaymentNotifyUrl = "https://www.yourNotifyUrl.com";
            request.PaymentRedirectUrl = "https://www.yourRedirectUrl.com";

            long amountInCents = 1000;
            Order order = new Order();
            order.OrderAmount = new Amount(currency, amountInCents);
            order.OrderDescription = "New White Lace Sleeveless";
            order.ReferenceOrderId = "0000000001999";
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

            return response.ClientPaymentToken;
        }

        private static void testQuery(DefaultAlipayClient client, string paymentRequestId)
        {
            PaymentInquiryRequest paymentInquiryRequest = new SandboxPaymentInquiryRequest();
            paymentInquiryRequest.PaymentRequestId = paymentRequestId;

            PaymentInquiryResponse paymentInquiryResponse = client.Execute(paymentInquiryRequest);

            Console.WriteLine("paymentInquiryResponse: \n" + paymentInquiryResponse);
        }

        private static void testCancel(DefaultAlipayClient client, string paymentRequestId)
        {
            PaymentCancelRequest paymentCancelRequest = new SandboxPaymentCancelRequest();
            paymentCancelRequest.PaymentRequestId = paymentRequestId;

            PaymentCancelResponse paymentCancelResponse = client.Execute(paymentCancelRequest);

            Console.WriteLine("paymentCancelResponse: \n" + paymentCancelResponse);
        }

        private static void testRefund(DefaultAlipayClient client, string paymentId, string currency)
        {
            PaymentRefundRequest paymentRefundRequest = new SandboxPaymentRefundRequest();
            paymentRefundRequest.PaymentId = paymentId;
            paymentRefundRequest.RefundRequestId = "erf_PR20190000000001_575" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            paymentRefundRequest.RefundAmount = new Amount(currency, 1000);
            paymentRefundRequest.RefundRequestTime = DateTime.UtcNow.ToString("o");

            PaymentRefundResponse paymentRefundResponse = client.Execute(paymentRefundRequest);

            Console.WriteLine("paymentRefundResponse: \n" + paymentRefundResponse);
        }

    }
}
