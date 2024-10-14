using System.Collections.Generic;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.pay
{
    public class AlipayPayConsultResponse : AMSResponse
    {
        public List<PaymentOption> PaymentOptions { get; set; }
        public List<PaymentMethodInfo> PaymentMethodInfos { get; set; }
        public string ExtendInfo { get; set; }
    }
}