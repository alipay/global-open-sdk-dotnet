using ams_dotnet.com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.marketplace;

public class AlipaySettleRequest:AMSRequest<AlipaySettleResponse>
{
    public string SettlementRequestId { get; set; }
    public string PaymentId { get; set; }
    public SettlementDetail[] SettlementDetails { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.MARKETPLACE_SETTLE_PATH;
    }
    
    public override void validate()
    {
           
    }
}