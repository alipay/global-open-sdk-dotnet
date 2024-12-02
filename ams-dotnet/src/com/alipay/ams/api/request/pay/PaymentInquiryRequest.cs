using System;
using System.Collections.Generic;
using System.Text.Json;

using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class PaymentInquiryRequest : AMSRequest<PaymentInquiryResponse>
    {
        public string PaymentRequestId { get; set; }
        
        public string PaymentId { get; set; }
        
        public string MerchantAccountId { get; set; }
        
        

        public override string GetRequestURI()
        {
            return AntomPathConstants.INQUIRY_PAYMENT_PATH;
        }

        public override void validate()
        {
 
        }
    }
}
