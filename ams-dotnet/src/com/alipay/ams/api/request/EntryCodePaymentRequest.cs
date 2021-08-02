using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class EntryCodePaymentRequest : CommonPaymentRequest<EntryCodePaymentResponse>
    {

        public EntryCodePaymentRequest()
        {
            this.ProductCode = ProductCodeType.IN_STORE_PAYMENT;
            this.PaymentMethod = new PaymentMethod(WalletPaymentMethodType.CONNECT_WALLET.ToString());
            this.PaymentFactor = new PaymentFactor();
            this.PaymentFactor.InStorePaymentScenario = InStorePaymentScenario.EntryCode;
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentRequestId, "paymentRequestId required.");
            Asserts.NotNull(PaymentAmount, "paymentAmount required.");
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
            Asserts.NotNull(Order.Env.UserAgent, "order.env.userAgent required.");
        }
    }
}
