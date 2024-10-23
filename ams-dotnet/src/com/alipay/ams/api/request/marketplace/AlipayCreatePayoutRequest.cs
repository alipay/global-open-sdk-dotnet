using ams_dotnet.com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.marketplace;

public class AlipayCreatePayoutRequest:AMSRequest<AlipayCreatePayoutResponse>
{
    public string TransferRequestId { get; set; }
    public TransferFromDetail TransferFromDetail { get; set; }
    public TransferToDetail TransferToDetail { get; set; }
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.MARKETPLACE_CREATEPAYOUT_PATH;
    }
    
    public override void validate()
    {
           
    }
}