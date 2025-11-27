using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayPayResponse : AMSResponse
    {

        public AlipayPayResponse() { }

        

        public AlipayPayResponse( Result result , Amount processingAmount , string paymentRequestId , string paymentId , Amount paymentAmount , string paymentData , Amount actualPaymentAmount , Quote paymentQuote , string paymentTime , string paymentCreateTime , string authExpiryTime , Amount nonGuaranteeCouponValue , string paymentActionForm , PspCustomerInfo pspCustomerInfo , ChallengeActionForm challengeActionForm , RedirectActionForm redirectActionForm , OrderCodeForm orderCodeForm , Amount grossSettlementAmount , Quote settlementQuote , string extendInfo , string normalUrl , string schemeUrl , string applinkUrl , string appIdentifier , PaymentResultInfo paymentResultInfo , AcquirerInfo acquirerInfo , PromotionResult[] promotionResult)
        {
            this.Result = result;
            this.ProcessingAmount = processingAmount;
            this.PaymentRequestId = paymentRequestId;
            this.PaymentId = paymentId;
            this.PaymentAmount = paymentAmount;
            this.PaymentData = paymentData;
            this.ActualPaymentAmount = actualPaymentAmount;
            this.PaymentQuote = paymentQuote;
            this.PaymentTime = paymentTime;
            this.PaymentCreateTime = paymentCreateTime;
            this.AuthExpiryTime = authExpiryTime;
            this.NonGuaranteeCouponValue = nonGuaranteeCouponValue;
            this.PaymentActionForm = paymentActionForm;
            this.PspCustomerInfo = pspCustomerInfo;
            this.ChallengeActionForm = challengeActionForm;
            this.RedirectActionForm = redirectActionForm;
            this.OrderCodeForm = orderCodeForm;
            this.GrossSettlementAmount = grossSettlementAmount;
            this.SettlementQuote = settlementQuote;
            this.ExtendInfo = extendInfo;
            this.NormalUrl = normalUrl;
            this.SchemeUrl = schemeUrl;
            this.ApplinkUrl = applinkUrl;
            this.AppIdentifier = appIdentifier;
            this.PaymentResultInfo = paymentResultInfo;
            this.AcquirerInfo = acquirerInfo;
            this.PromotionResult = promotionResult;
        }

            public Result Result { get; set; }
            public Amount ProcessingAmount { get; set; }
            public string PaymentRequestId { get; set; }
            public string PaymentId { get; set; }
            public Amount PaymentAmount { get; set; }
            public string PaymentData { get; set; }
            public Amount ActualPaymentAmount { get; set; }
            public Quote PaymentQuote { get; set; }
            public string PaymentTime { get; set; }
            public string PaymentCreateTime { get; set; }
            public string AuthExpiryTime { get; set; }
            public Amount NonGuaranteeCouponValue { get; set; }
            public string PaymentActionForm { get; set; }
            public PspCustomerInfo PspCustomerInfo { get; set; }
            public ChallengeActionForm ChallengeActionForm { get; set; }
            public RedirectActionForm RedirectActionForm { get; set; }
            public OrderCodeForm OrderCodeForm { get; set; }
            public Amount GrossSettlementAmount { get; set; }
            public Quote SettlementQuote { get; set; }
            public string ExtendInfo { get; set; }
            public string NormalUrl { get; set; }
            public string SchemeUrl { get; set; }
            public string ApplinkUrl { get; set; }
            public string AppIdentifier { get; set; }
            public PaymentResultInfo PaymentResultInfo { get; set; }
            public AcquirerInfo AcquirerInfo { get; set; }
            public PromotionResult[] PromotionResult { get; set; }

        

    }

}
