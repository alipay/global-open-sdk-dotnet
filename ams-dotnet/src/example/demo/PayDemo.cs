using System;
using ams_dotnet.com.alipay.ams.api.request.subscription;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;

namespace ams_dotnet.demo
{
    public class PayDemo
    {
        
        public static string alipay(DefaultAlipayClient client)
        {
            var request = new PaymentCreateRequest();

            request.ProductCode = ProductCodeType.CASHIER_PAYMENT;
            request.PaymentAmount = new Amount("HKD", 100);
            var paymentMethod = new PaymentMethod(WalletPaymentMethodType.ALIPAY_HK.ToString());
            paymentMethod.PaymentMethodId = "1213213423";
            request.PaymentMethod = paymentMethod;
            request.PaymentNotifyUrl = "http  //alipay.com";
            request.PaymentRedirectUrl = "http  //alipay.com";

            Order order = new Order();
            order.OrderAmount = new Amount("HKD", 100);
            order.OrderDescription = "example order";
            order.ReferenceOrderId = "0001213243200001";
            order.Merchant = new Merchant("example merchant", "seller231117459", "7011", new Store(
                "Some_store", "store231117459", "7011"));
            
            var env = new Env();
            env.OsType = OsType.ANDROID;
            env.TerminalType = TerminalType.WEB;
            
            order.Env = env;

            request.PaymentRequestId =  "PR20190000000001_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            request.Order = order;

            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.PaymentId;
        }


        public static void query(DefaultAlipayClient client, string paymentRequestId)
        {
            PaymentInquiryRequest paymentInquiryRequest = new PaymentInquiryRequest();
            paymentInquiryRequest.PaymentRequestId = paymentRequestId;

            PaymentInquiryResponse paymentInquiryResponse = client.Execute(paymentInquiryRequest);

            Console.WriteLine("paymentInquiryResponse   \n" + paymentInquiryResponse);
        }

        public static void cancel(DefaultAlipayClient client, string paymentRequestId)
        {
            PaymentCancelRequest paymentCancelRequest = new PaymentCancelRequest();
            paymentCancelRequest.PaymentRequestId = paymentRequestId;

            PaymentCancelResponse paymentCancelResponse = client.Execute(paymentCancelRequest);

            Console.WriteLine("paymentCancelResponse   \n" + paymentCancelResponse);
        }

        public static void refund(DefaultAlipayClient client, string paymentId)
        {
            PaymentRefundRequest paymentRefundRequest = new PaymentRefundRequest();
            paymentRefundRequest.PaymentId = paymentId;
            paymentRefundRequest.RefundRequestId = "erf_PR20190000000001_575" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            paymentRefundRequest.RefundAmount = new Amount("HKD", 100);
            paymentRefundRequest.RefundRequestTime = DateTime.UtcNow.ToString("o");

            var paymentRefundResponse = client.Execute(paymentRefundRequest);

            Console.WriteLine("     \n" +  paymentRefundResponse );
        }
        public static void queryRefund(DefaultAlipayClient client, string refundRequestId)
        {
            AlipayInquiryRefundRequest paymentRefundRequest = new AlipayInquiryRefundRequest();
            paymentRefundRequest.RefundRequestId = refundRequestId;
            var alipayInquiryRefundResponse = client.Execute(paymentRefundRequest);

            Console.WriteLine("     \n" + alipayInquiryRefundResponse);
        }

        public static void consult(DefaultAlipayClient client)
        {
            var request = new AlipayPayConsultRequest();
            var settlementStrategy = new SettlementStrategy();
            settlementStrategy.SettlementCurrency = "USD";
            request.SettlementStrategy = settlementStrategy;

            request.ProductCode = ProductCodeType.CASHIER_PAYMENT;
            request.UserRegion = "SG";
            request.AllowedPaymentMethodRegions = new[] { "SG", "HK", "CN" };
            var env = new Env();
            env.OsType = OsType.IOS;
            env.TerminalType = TerminalType.APP;
            request.Env = env;
            request.PaymentAmount = new Amount("USD", 100);
            var paymentFactor = new PaymentFactor();
            paymentFactor.PresentmentMode = PresentmentMode.BUNDLE;
            request.PaymentFactor = paymentFactor;
            var response = client.Execute(request);

            Console.WriteLine(" \n" + response);
        }

        public static void createSession(DefaultAlipayClient client)
        {
            var request = new AlipayPaymentSessionRequest();
            request.PaymentRequestId =  "PR20190000000001_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
            Order order = new Order();
            order.OrderAmount = new Amount("HKD", 100);
            order.OrderDescription = "example order";
            order.ReferenceOrderId = "0001213243200001";
            var buyer = new Buyer();
            buyer.ReferenceBuyerId  = "111112132143434";
            order.Buyer = buyer;
            var env = new Env();
            env.OsType = OsType.IOS;
            env.TerminalType = TerminalType.APP;
            request.Env = env;
            request.Order = order;
            request.ProductCode = ProductCodeType.CASHIER_PAYMENT;
            request.PaymentAmount = new Amount("HKD", 100);
            var paymentMethod = new PaymentMethod(WalletPaymentMethodType.SHOPEEPAY_SG.ToString());
            request.PaymentMethod = paymentMethod;
            request.PaymentNotifyUrl = "http://alipay.com";
            request.PaymentRedirectUrl = "http://alipay.com";
            
            var response = client.Execute(request);

            Console.WriteLine(" \n" + response);
            
        }
    }
}