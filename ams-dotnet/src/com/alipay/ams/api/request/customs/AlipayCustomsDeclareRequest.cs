using System;
using ams_dotnet.com.alipay.ams.api.response.customs;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.customs
{
    public class AlipayCustomsDeclareRequest : AMSRequest<AlipayCustomsDeclareResponse>
    {
        public string DeclarationRequestId { get; set; }
        public string PaymentId { get; set; }
        public Amount DeclarationAmount { get; set; }
        public CustomsInfo Customs { get; set; }
        public MerchantCustomsInfo MerchantCustomsInfo { get; set; }
        public Boolean SplitOrder { get; set; }
        public string SubOrderId { get; set; }
        public Certificate BuyerCertificate { get; set; }
        
        
        public override string GetRequestURI()
        {
            return AntomPathConstants.DECLARE_PATH;
        }

        public override void validate()
        {
            
        }
    }
}