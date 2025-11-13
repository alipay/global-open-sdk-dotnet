using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayPayQueryResponse : AMSResponse
    {

        public AlipayPayQueryResponse() { }

        

        public AlipayPayQueryResponse(  Result  result ,  TransactionStatusType  paymentStatus ,  string  paymentResultCode ,  string  paymentResultMessage ,  string  paymentRequestId ,  string  paymentId ,  string  authPaymentId ,  Amount  paymentAmount ,  Amount  actualPaymentAmount ,  Quote  paymentQuote ,  string  authExpiryTime ,  string  paymentCreateTime ,  string  paymentTime ,  Amount  nonGuaranteeCouponAmount ,  PspCustomerInfo  pspCustomerInfo ,  RedirectActionForm  redirectActionForm ,  CardInfo  cardInfo ,  string  acquirerReferenceNo ,  string  extendInfo ,  List<Transaction>  transactions ,  Amount  customsDeclarationAmount ,  Amount  grossSettlementAmount ,  Quote  settlementQuote ,  PaymentResultInfo  paymentResultInfo ,  AcquirerInfo  acquirerInfo ,  string  merchantAccountId ,  List<PromotionResult>  promotionResults ,  string  earliestSettlementTime ,  string  paymentMethodType)
        {
            this.Result = result;
            this.PaymentStatus = paymentStatus;
            this.PaymentResultCode = paymentResultCode;
            this.PaymentResultMessage = paymentResultMessage;
            this.PaymentRequestId = paymentRequestId;
            this.PaymentId = paymentId;
            this.AuthPaymentId = authPaymentId;
            this.PaymentAmount = paymentAmount;
            this.ActualPaymentAmount = actualPaymentAmount;
            this.PaymentQuote = paymentQuote;
            this.AuthExpiryTime = authExpiryTime;
            this.PaymentCreateTime = paymentCreateTime;
            this.PaymentTime = paymentTime;
            this.NonGuaranteeCouponAmount = nonGuaranteeCouponAmount;
            this.PspCustomerInfo = pspCustomerInfo;
            this.RedirectActionForm = redirectActionForm;
            this.CardInfo = cardInfo;
            this.AcquirerReferenceNo = acquirerReferenceNo;
            this.ExtendInfo = extendInfo;
            this.Transactions = transactions;
            this.CustomsDeclarationAmount = customsDeclarationAmount;
            this.GrossSettlementAmount = grossSettlementAmount;
            this.SettlementQuote = settlementQuote;
            this.PaymentResultInfo = paymentResultInfo;
            this.AcquirerInfo = acquirerInfo;
            this.MerchantAccountId = merchantAccountId;
            this.PromotionResults = promotionResults;
            this.EarliestSettlementTime = earliestSettlementTime;
            this.PaymentMethodType = paymentMethodType;
        }

            public  Result  Result { get; set; }
            public  TransactionStatusType  PaymentStatus { get; set; }
            public  string  PaymentResultCode { get; set; }
            public  string  PaymentResultMessage { get; set; }
            public  string  PaymentRequestId { get; set; }
            public  string  PaymentId { get; set; }
            public  string  AuthPaymentId { get; set; }
            public  Amount  PaymentAmount { get; set; }
            public  Amount  ActualPaymentAmount { get; set; }
            public  Quote  PaymentQuote { get; set; }
            public  string  AuthExpiryTime { get; set; }
            public  string  PaymentCreateTime { get; set; }
            public  string  PaymentTime { get; set; }
            public  Amount  NonGuaranteeCouponAmount { get; set; }
            public  PspCustomerInfo  PspCustomerInfo { get; set; }
            public  RedirectActionForm  RedirectActionForm { get; set; }
            public  CardInfo  CardInfo { get; set; }
            public  string  AcquirerReferenceNo { get; set; }
            public  string  ExtendInfo { get; set; }
            public  List<Transaction>  Transactions { get; set; }
            public  Amount  CustomsDeclarationAmount { get; set; }
            public  Amount  GrossSettlementAmount { get; set; }
            public  Quote  SettlementQuote { get; set; }
            public  PaymentResultInfo  PaymentResultInfo { get; set; }
            public  AcquirerInfo  AcquirerInfo { get; set; }
            public  string  MerchantAccountId { get; set; }
            public  List<PromotionResult>  PromotionResults { get; set; }
            public  string  EarliestSettlementTime { get; set; }
            public  string  PaymentMethodType { get; set; }

        

    }

}
