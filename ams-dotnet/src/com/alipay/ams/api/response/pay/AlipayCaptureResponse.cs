using System;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.pay
{
    public class AlipayCaptureResponse : AMSResponse
    {
        public string CaptureRequestId { get; set; }
        public string CaptureId { get; set; }
        public string PaymentId { get; set; }
        public Amount CaptureAmount { get; set; }
        public string CaptureTime { get; set; }
        public string AcquirerReferenceNo  { get; set; }
        
    }
}