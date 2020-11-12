using System;
using com.alipay.ams.api;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;
using com.alipay.ams.api.request.auth;
using com.alipay.ams.api.response.auth;

namespace ams_dotnet.example.tests
{
    public class AutoDebitTest
    {
        //RequestURIs of Auto Debit APIs in sandbox are different from what are in production.

        class SandboxAlipayAuthConsultRequest : AlipayAuthConsultRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/authorizations/consult";
            }

        }

        class SandboxAlipayAuthApplyTokenRequest : AlipayAuthApplyTokenRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/authorizations/applyToken";
            }

        }

        class SandboxAlipayAuthRevokeTokenRequest : AlipayAuthRevokeTokenRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/authorizations/revoke";
            }

        }

        class SandboxAlipayInitAuthenticationRequest : AlipayInitAuthenticationRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/users/initAuthentication";
            }

        }

        class SandboxAlipayUserQueryInfoRequest : AlipayUserQueryInfoRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/users/inquiryUserInfo";
            }

        }

        class SandboxAlipayVerifyAuthenticationRequest : AlipayVerifyAuthenticationRequest
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/users/verifyAuthentication";
            }

        }


        class SandboxCommonPaymentRequest : CommonPaymentRequest<CommonPaymentResponse>
        {
            public override string GetRequestURI()
            {
                return "/ams/sandbox/api/v1/payments/pay";
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
            string requestId = "PR20190000000001_" + (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;

            //string authUrl = testAuthConsult(client, authState);

            var response = testApplyToken(client);

            //string accessToken = testRefreshToken(client, response.RefreshToken);

            //testRevokeToken(client, accessToken);

            //AlipayInitAuthenticationResponse iar = testInitAuthentication(client, response.AccessToken, requestId);
            //testVerifyAuthentication(client, iar.AuthenticationRequestId);

            //testInquiryUserInfo(client, response.AccessToken);

            string paymentId = testDebitPayment(client, response.AccessToken, currency, requestId);

            testQuery(client, requestId);

            testRefund(client, paymentId, currency);

            testCancel(client, requestId);

        }



        private static string testAuthConsult(DefaultAlipayClient client, string authState)
        {
            SandboxAlipayAuthConsultRequest sandboxAlipayAuthConsultRequest = new SandboxAlipayAuthConsultRequest();
            sandboxAlipayAuthConsultRequest.AuthClientId = "FOO";
            sandboxAlipayAuthConsultRequest.AuthRedirectUrl= "http://alipay.com";
            sandboxAlipayAuthConsultRequest.CustomerBelongsTo = CustomerBelongsTo.GCASH;
            sandboxAlipayAuthConsultRequest.Scopes = new ScopeType[] { ScopeType.AGREEMENT_PAY};
            sandboxAlipayAuthConsultRequest.AuthState = authState;
            sandboxAlipayAuthConsultRequest.TerminalType = TerminalType.APP;
            sandboxAlipayAuthConsultRequest.OsType = OsType.IOS;
            sandboxAlipayAuthConsultRequest.OsVersion = "bar";

            com.alipay.ams.api.response.auth.AlipayAuthConsultResponse response = client.Execute(sandboxAlipayAuthConsultRequest);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.AuthUrl;
        }

        private static AlipayAuthApplyTokenResponse testApplyToken(DefaultAlipayClient client)
        {
            var request = new SandboxAlipayAuthApplyTokenRequest();
            request.AuthCode = "foo";
            request.CustomerBelongsTo = CustomerBelongsTo.GCASH;
            request.GrantType = GrantType.AUTHORIZATION_CODE;

            Console.WriteLine(request);
            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response;
        }

        private static string testRefreshToken(DefaultAlipayClient client, string refreshToken)
        {
            var request = new SandboxAlipayAuthApplyTokenRequest();
            request.RefreshToken = refreshToken;
            request.CustomerBelongsTo = CustomerBelongsTo.GCASH;
            request.GrantType = GrantType.REFRESH_TOKEN;

            Console.WriteLine(request);
            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.AccessToken;
        }

        private static string testRevokeToken(DefaultAlipayClient client, string accessToken)
        {
            var request = new SandboxAlipayAuthRevokeTokenRequest();
            request.AccessToken = accessToken;

            Console.WriteLine(request);
            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.ToString();
        }

        private static AlipayInitAuthenticationResponse testInitAuthentication(DefaultAlipayClient client, string accessToken, string authenticationRequestId)
        {
            var request = new SandboxAlipayInitAuthenticationRequest();
            request.AuthenticationChannelType = AuthenticationChannelType.SMS;
            request.AuthenticationType = AuthenticationType.OTP;
            request.AuthenticationRequestId = authenticationRequestId;
            request.UserIdentityType = UserIdentityType.WALLET_TOKEN;
            request.UserIdentityValue = accessToken;

            Console.WriteLine(request);
            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response;
        }

        private static string testVerifyAuthentication(DefaultAlipayClient client, string authenticationRequestId)
        {
            var request = new SandboxAlipayVerifyAuthenticationRequest();
            request.AuthenticationRequestId = authenticationRequestId;
            request.AuthenticationType = AuthenticationType.OTP;
            request.AuthenticationValue = "FOO";

            Console.WriteLine(request);
            var response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.ToString();
        }

        private static string testInquiryUserInfo(DefaultAlipayClient client, string accessToken)
        {
            var request = new SandboxAlipayUserQueryInfoRequest();
            request.AccessToken = accessToken;

            Console.WriteLine(request);
            AlipayUserQueryInfoResponse response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.UserLoginId;
        }

        private static string testDebitPayment(DefaultAlipayClient client, string accessToken, string currency, string paymentRequestId)
        {
            var request = new SandboxCommonPaymentRequest();

            request.ProductCode = ProductCodeType.AGREEMENT_PAYMENT;
            request.PaymentAmount = new Amount(currency, 3000);
            request.PaymentMethod = new PaymentMethod(WalletPaymentMethodType.GCASH.ToString());
            request.PaymentMethod.PaymentMethodId = accessToken;
            request.PaymentNotifyUrl = "http://alipay.com";
            request.PaymentRedirectUrl = "http://alipay.com";

            long amountInCents = 1000;
            Order order = new Order();
            order.OrderAmount = new Amount(currency, amountInCents);
            order.OrderDescription = "New White Lace Sleeveless";
            order.ReferenceOrderId = "0000000001";
            order.Merchant = new Merchant("Some_Mer", "seller231117459", "7011", new Store(
                "Some_store", "store231117459", "7011"));

            request.PaymentRequestId = paymentRequestId;
            request.Order = order;

            Console.WriteLine(request);

            CommonPaymentResponse response = client.Execute(request);

            Console.WriteLine("\n============================================================\n");
            Console.WriteLine(response);

            return response.PaymentId;
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
