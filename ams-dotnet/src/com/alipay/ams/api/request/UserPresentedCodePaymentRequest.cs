using System;
using System.Collections.Generic;
using System.Text.Json;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class UserPresentedCodePaymentRequest : AMSRequest<UserPresentedCodePaymentResponse>
    {

        public string PaymentRequestId { get; set; }
        public entities.Order Order { get; set; }
        public string Currency { get; set; }
        public long AmountInCents { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentNotifyUrl { get; set; }
        public DateTime PaymentExpiryTime { get; set; }



        public override string BuildBody()
        {

            validate();

            var body = new Dictionary<string,object>();

            body.Add("productCode", "IN_STORE_PAYMENT");
            body.Add("paymentRequestId", PaymentRequestId);

            body.Add("order", Order);

            if (PaymentNotifyUrl != null)
            {
                body.Add("paymentNotifyUrl", PaymentNotifyUrl);
            }

            if (PaymentExpiryTime != null)
            {
                body.Add("paymentExpiryTime", PaymentExpiryTime.ToString("o"));
            }

            var paymentAmount = new Amount(Currency, AmountInCents);
            body.Add("paymentAmount", paymentAmount);

            var paymentMethod = new Dictionary<String, String>();
            paymentMethod.Add("paymentMethodType", "CONNECT_WALLET");
            paymentMethod.Add("paymentMethodId", PaymentCode);
            body.Add("paymentMethod", paymentMethod);

            var paymentFactor = new Dictionary<String, Object>();
            paymentFactor.Add("inStorePaymentScenario", "PaymentCode");
            body.Add("paymentFactor", paymentFactor);


            return JsonSerializer.Serialize(body);
        }

        public override string GetRequestURI()
        {
            return "/ams/api/v1/payments/pay";
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentRequestId, "paymentRequestId required.");
            Asserts.NotNull(PaymentCode, "paymentCode required.");
            Asserts.NotNull(Currency, "currency required.");
            Asserts.NotNull(AmountInCents, "amountInCents required.");
            Asserts.NotNull(Order, "order required.");
            Asserts.NotNull(Order.Merchant, "order.merchant required.");
            Asserts.NotNull(Order.OrderAmount, "order.orderAmount required.");
            Asserts.NotNull(Order.OrderDescription, "order.orderDescription required.");
            Asserts.NotNull(Order.Merchant.ReferenceMerchantId,
                "order.merchant.referenceMerchantId required.");
            Asserts.NotNull(Order.Merchant.MerchantMCC,
                "order.merchant.merchantMcc required.");
            Asserts.NotNull(Order.Merchant.MerchantName,
                "order.merchant.merchantName required.");
            Asserts.NotNull(Order.Merchant.Store, "order.merchant.store required.");
            Asserts.NotNull(Order.Merchant.Store.ReferenceStoreId,
                "order.merchant.store.referenceStoreId required.");
            Asserts.NotNull(Order.Merchant.Store.StoreName,
                "order.merchant.store.storeName required.");
            Asserts.NotNull(Order.Merchant.Store.StoreMCC,
                "order.merchant.store.storeMcc required.");
            Asserts.NotNull(Order.Env, "order.env required.");
            Asserts.NotNull(Order.Env.StoreTerminalId, "order.env.storeTerminalId required.");
            Asserts.NotNull(Order.Env.StoreTerminalRequestTime,
                "order.env.storeTerminalRequestTime required.");
        }
    }
}
