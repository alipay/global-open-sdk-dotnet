using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayPayRequest : AMSRequest<AlipayPayResponse>
    {

        public AlipayPayRequest() { }

        

        public AlipayPayRequest( CustomizedInfo customizedInfo , Quote paymentQuote , AgreementInfo agreementInfo , SubscriptionInfo subscriptionInfo , Amount processingAmount , ProductCodeType productCode , string paymentRequestId , Order order , Amount paymentAmount , PaymentMethod paymentMethod , string paymentExpiryTime , string paymentRedirectUrl , string paymentNotifyUrl , PaymentFactor paymentFactor , SettlementStrategy settlementStrategy , CreditPayPlan creditPayPlan , string appId , string merchantRegion , string userRegion , Env env , PaymentMethod payToMethod , bool? isAuthorization , Merchant merchant , PaymentVerificationData paymentVerificationData , string extendInfo , string merchantAccountId , bool? dualOfflinePayment)
        {
            this.CustomizedInfo = customizedInfo;
            this.PaymentQuote = paymentQuote;
            this.AgreementInfo = agreementInfo;
            this.SubscriptionInfo = subscriptionInfo;
            this.ProcessingAmount = processingAmount;
            this.ProductCode = productCode;
            this.PaymentRequestId = paymentRequestId;
            this.Order = order;
            this.PaymentAmount = paymentAmount;
            this.PaymentMethod = paymentMethod;
            this.PaymentExpiryTime = paymentExpiryTime;
            this.PaymentRedirectUrl = paymentRedirectUrl;
            this.PaymentNotifyUrl = paymentNotifyUrl;
            this.PaymentFactor = paymentFactor;
            this.SettlementStrategy = settlementStrategy;
            this.CreditPayPlan = creditPayPlan;
            this.AppId = appId;
            this.MerchantRegion = merchantRegion;
            this.UserRegion = userRegion;
            this.Env = env;
            this.PayToMethod = payToMethod;
            this.IsAuthorization = isAuthorization;
            this.Merchant = merchant;
            this.PaymentVerificationData = paymentVerificationData;
            this.ExtendInfo = extendInfo;
            this.MerchantAccountId = merchantAccountId;
            this.DualOfflinePayment = dualOfflinePayment;
        }

            public CustomizedInfo CustomizedInfo { get; set; }
            public Quote PaymentQuote { get; set; }
            public AgreementInfo AgreementInfo { get; set; }
            public SubscriptionInfo SubscriptionInfo { get; set; }
            public Amount ProcessingAmount { get; set; }
            public ProductCodeType ProductCode { get; set; }
            public string PaymentRequestId { get; set; }
            public Order Order { get; set; }
            public Amount PaymentAmount { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public string PaymentExpiryTime { get; set; }
            public string PaymentRedirectUrl { get; set; }
            public string PaymentNotifyUrl { get; set; }
            public PaymentFactor PaymentFactor { get; set; }
            public SettlementStrategy SettlementStrategy { get; set; }
            public CreditPayPlan CreditPayPlan { get; set; }
            public string AppId { get; set; }
            public string MerchantRegion { get; set; }
            public string UserRegion { get; set; }
            public Env Env { get; set; }
            public PaymentMethod PayToMethod { get; set; }
            public bool? IsAuthorization { get; set; }
            public Merchant Merchant { get; set; }
            public PaymentVerificationData PaymentVerificationData { get; set; }
            public string ExtendInfo { get; set; }
            public string MerchantAccountId { get; set; }
            public bool? DualOfflinePayment { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/pay"; } 


    }

}
