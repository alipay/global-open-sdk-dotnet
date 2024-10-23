using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.marketplace;

public class AlipaySettleResponse:AMSResponse
{
    public string SettlementRequestId { get; set; }
    public string SettlementId { get; set; }
}