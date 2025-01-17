
using System.Collections.Generic;

using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class PaymentInquiryResponse : AMSResponse
    {
        
        public Amount ActualPaymentAmount { get; set; }
        
        public Amount PaymentAmount { get; set; }
        
        public string PaymentId { get; set; }
        
        public Quote PaymentQuote { get; set; }
        
        public string PaymentRequestId { get; set; }
        
        public string PaymentTime { get; set; }
        
        public PspCustomerInfo PspCustomerInfo { get; set; }
        
        public string PaymentResultCode { get; set; }
        
        public string PaymentResultMessage { get; set; }
        
        public string PaymentStatus { get; set; }
        
        public string AuthPaymentId { get; set; }
        
        public string AuthExpiryTime { get; set; }
        
       public string PaymentCreateTime  { get; set; }
       public Amount NonGuaranteeCouponAmount  { get; set; }
       public RedirectActionForm RedirectActionForm  { get; set; }
       public CardInfo CardInfo  { get; set; }
       public string AcquirerReferenceNo  { get; set; }
       public string ExtendInfo  { get; set; }
       public List<Transaction> Transactions  { get; set; }
       public Amount CustomsDeclarationAmount  { get; set; }
       public Amount GrossSettlementAmount  { get; set; }
       public Quote SettlementQuote  { get; set; }
       public PaymentResultInfo PaymentResultInfo  { get; set; }
       public AcquirerInfo AcquirerInfo  { get; set; }
       public string MerchantAccountId  { get; set; }
       public List<PromotionResult> PromotionResult  { get; set; }
       public string EarliestSettlementTime  { get; set; }
       public string PaymentMethodType { get; set; }

    }
}