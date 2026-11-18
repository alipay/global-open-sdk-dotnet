
using System.Collections.Generic;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    public class PaymentCreateResponse : AMSResponse
    {


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
        public List<PromotionResult> PromotionResult { get; set; }
        

        public string ClientPaymentToken { get; set; }
        

    }
}