using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.dispute;

public class AlipaySupplyDefenseDocumentResponse:AMSResponse
{
    public string DisputeId { get; set; }
    public string DisputeResolutionTime { get; set; }
}