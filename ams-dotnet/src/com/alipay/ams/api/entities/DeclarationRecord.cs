using System;

namespace com.alipay.ams.api.entities
{
    public class DeclarationRecord
    {
        public string DeclarationRequestId { get; set; }
        public string CustomsPaymentId { get; set; }
        public string CustomsOrderId { get; set; }
        public CustomsInfo Customs { get; set; }
        public MerchantCustomsInfo MerchantCustomsInfo { get; set; }
        public Amount DeclarationAmount { get; set; }
        public Boolean SplitOrder { get; set; }
        public string DeclarationRequestStatus { get; set; }
        public string LastModifiedTime { get; set; }
        public string CustomsDeclarationResultCode { get; set; }
        public string CustomsDeclarationResultDesc { get; set; }
        public string CustomsDeclarationReturnTime { get; set; }
    }
}