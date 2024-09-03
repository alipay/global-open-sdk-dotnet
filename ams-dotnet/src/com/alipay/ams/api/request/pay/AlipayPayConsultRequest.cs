using System.Collections.Generic;
using ams_dotnet.com.alipay.ams.api.response.pay;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request
{
    public class AlipayPayConsultRequest : AMSRequest<AlipayPayConsultResponse>
    {
        public ProductCodeType ProductCode { get; set; }
        public Amount PaymentAmount { get; set; }
        public string MerchantRegion { get; set; }
        public string[] AllowedPaymentMethodRegions { get; set; }
        public string[] AllowedPaymentMethods { get; set; }
        public string[] BlockedPaymentMethods { get; set; }
        public string Region { get; set; }
        public string CustomerId { get; set; }
        public string ReferenceUserId { get; set; }
        public Env Env { get; set; }
        public string ExtendInfo { get; set; }
        public string UserRegion { get; set; }
        public PaymentFactor PaymentFactor  { get; set; }
        public SettlementStrategy SettlementStrategy  { get; set; }
        public Merchant Merchant  { get; set; }
        public string[] AllowedPspRegions { get; set; }
        public Buyer Buyer { get; set; }
        
        public override string GetRequestURI()
        {
            return AntomPathConstants.CONSULT_PAYMENT_PATH;
        }

        public override void validate()
        {
           
        }
    }
}