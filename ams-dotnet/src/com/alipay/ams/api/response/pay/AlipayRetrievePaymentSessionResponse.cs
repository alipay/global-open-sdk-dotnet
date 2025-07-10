using System.Collections.Generic;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.pay;

public class AlipayRetrievePaymentSessionResponse : AMSResponse
{
    public Order Order { get; set; }
    public List<PromotionResult> PromotionResults { get; set; }
    public string CustomizedInfo { get; set; }
}