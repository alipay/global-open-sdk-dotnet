using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayPayConsultRequest : AMSRequest<AlipayPayConsultResponse>
    {

        public AlipayPayConsultRequest() { }

        public AlipayPayConsultRequest( ProductCodeType productCode , Amount paymentAmount , string merchantRegion , List<string> allowedPaymentMethodRegions , List<string> allowedPaymentMethods , List<string> blockedPaymentMethods , string region , string customerId , string referenceUserId , Env env , string extendInfo , string userRegion , PaymentFactor paymentFactor , SettlementStrategy settlementStrategy , Merchant merchant , List<string> allowedPspRegions , Buyer buyer , string merchantAccountId)
        {
            this.ProductCode = productCode;
            this.PaymentAmount = paymentAmount;
            this.MerchantRegion = merchantRegion;
            this.AllowedPaymentMethodRegions = allowedPaymentMethodRegions;
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.BlockedPaymentMethods = blockedPaymentMethods;
            this.Region = region;
            this.CustomerId = customerId;
            this.ReferenceUserId = referenceUserId;
            this.Env = env;
            this.ExtendInfo = extendInfo;
            this.UserRegion = userRegion;
            this.PaymentFactor = paymentFactor;
            this.SettlementStrategy = settlementStrategy;
            this.Merchant = merchant;
            this.AllowedPspRegions = allowedPspRegions;
            this.Buyer = buyer;
            this.MerchantAccountId = merchantAccountId;
        }

            public ProductCodeType ProductCode { get; set; }
            public Amount PaymentAmount { get; set; }
            public string MerchantRegion { get; set; }
            public List<string> AllowedPaymentMethodRegions { get; set; }
            public List<string> AllowedPaymentMethods { get; set; }
            public List<string> BlockedPaymentMethods { get; set; }
            public string Region { get; set; }
            public string CustomerId { get; set; }
            public string ReferenceUserId { get; set; }
            public Env Env { get; set; }
            public string ExtendInfo { get; set; }
            public string UserRegion { get; set; }
            public PaymentFactor PaymentFactor { get; set; }
            public SettlementStrategy SettlementStrategy { get; set; }
            public Merchant Merchant { get; set; }
            public List<string> AllowedPspRegions { get; set; }
            public Buyer Buyer { get; set; }
            public string MerchantAccountId { get; set; }

        public override string GetRequestURI(){ 
    return "/ams/api/v1/payments/consult"; 
} 


    }

}
