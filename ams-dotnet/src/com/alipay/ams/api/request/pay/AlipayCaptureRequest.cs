using System;
using ams_dotnet.com.alipay.ams.api.response.pay;
using com.alipay.ams.api.entities;
using com.alipay.ams.util;

namespace com.alipay.ams.api.request
{
    public class AlipayCaptureRequest : AMSRequest<AlipayCaptureResponse>
    {
        public string CaptureRequestId { get; set; }
        public string PaymentId { get; set; }
        public Amount CaptureAmount { get; set; }
        public Boolean IsLastCapture { get; set; }
        
        
        public override string GetRequestURI()
        {
            return AntomPathConstants.CAPTURE_PATH;
        }

        public override void validate()
        {
            Asserts.NotNull(PaymentId, "PaymentId required.");
        }
        
    }
    
   
}