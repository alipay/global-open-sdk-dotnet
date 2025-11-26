using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayPaymentSessionRequest : AMSRequest<AlipayPaymentSessionResponse>
    {

        public AlipayPaymentSessionRequest() { }

        

        public AlipayPaymentSessionRequest( string allowedPaymentMethodRegions , CustomizedInfo customizedInfo , Quote paymentQuote , Amount processingAmount , SubscriptionPlan subscriptionPlan , SubscriptionInfo subscriptionInfo , string userRegion , List<string> scopes , ProductCodeType productCode , string paymentRequestId , Order order , Amount paymentAmount , PaymentMethod paymentMethod , string paymentSessionExpiryTime , string paymentRedirectUrl , string paymentNotifyUrl , PaymentFactor paymentFactor , SettlementStrategy settlementStrategy , bool? enableInstallmentCollection , CreditPayPlan creditPayPlan , string merchantRegion , Env env , AgreementInfo agreementInfo , RiskData riskData , string productScene , List<PaymentMethod> savedPaymentMethods , string locale , AvailablePaymentMethod availablePaymentMethod , string paymentExpiryTime)
        {
            this.AllowedPaymentMethodRegions = allowedPaymentMethodRegions;
            this.CustomizedInfo = customizedInfo;
            this.PaymentQuote = paymentQuote;
            this.ProcessingAmount = processingAmount;
            this.SubscriptionPlan = subscriptionPlan;
            this.SubscriptionInfo = subscriptionInfo;
            this.UserRegion = userRegion;
            this.Scopes = scopes;
            this.ProductCode = productCode;
            this.PaymentRequestId = paymentRequestId;
            this.Order = order;
            this.PaymentAmount = paymentAmount;
            this.PaymentMethod = paymentMethod;
            this.PaymentSessionExpiryTime = paymentSessionExpiryTime;
            this.PaymentRedirectUrl = paymentRedirectUrl;
            this.PaymentNotifyUrl = paymentNotifyUrl;
            this.PaymentFactor = paymentFactor;
            this.SettlementStrategy = settlementStrategy;
            this.EnableInstallmentCollection = enableInstallmentCollection;
            this.CreditPayPlan = creditPayPlan;
            this.MerchantRegion = merchantRegion;
            this.Env = env;
            this.AgreementInfo = agreementInfo;
            this.RiskData = riskData;
            this.ProductScene = productScene;
            this.SavedPaymentMethods = savedPaymentMethods;
            this.Locale = locale;
            this.AvailablePaymentMethod = availablePaymentMethod;
            this.PaymentExpiryTime = paymentExpiryTime;
        }

            public string AllowedPaymentMethodRegions { get; set; }
            public CustomizedInfo CustomizedInfo { get; set; }
            public Quote PaymentQuote { get; set; }
            public Amount ProcessingAmount { get; set; }
            public SubscriptionPlan SubscriptionPlan { get; set; }
            public SubscriptionInfo SubscriptionInfo { get; set; }
            public string UserRegion { get; set; }
            public List<string> Scopes { get; set; }
            public ProductCodeType ProductCode { get; set; }
            public string PaymentRequestId { get; set; }
            public Order Order { get; set; }
            public Amount PaymentAmount { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public string PaymentSessionExpiryTime { get; set; }
            public string PaymentRedirectUrl { get; set; }
            public string PaymentNotifyUrl { get; set; }
            public PaymentFactor PaymentFactor { get; set; }
            public SettlementStrategy SettlementStrategy { get; set; }
            public bool? EnableInstallmentCollection { get; set; }
            public CreditPayPlan CreditPayPlan { get; set; }
            public string MerchantRegion { get; set; }
            public Env Env { get; set; }
            public AgreementInfo AgreementInfo { get; set; }
            public RiskData RiskData { get; set; }
            public string ProductScene { get; set; }
            public List<PaymentMethod> SavedPaymentMethods { get; set; }
            public string Locale { get; set; }
            public AvailablePaymentMethod AvailablePaymentMethod { get; set; }
            public string PaymentExpiryTime { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/createPaymentSession"; } 


    }

}
