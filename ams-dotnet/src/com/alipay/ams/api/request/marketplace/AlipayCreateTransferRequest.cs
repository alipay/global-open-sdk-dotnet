using ams_dotnet.com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.marketplace;

public class AlipayCreateTransferRequest:AMSRequest<AlipayCreateTransferResponse>
{
    public string TransferRequestId { get; set; }
    public TransferFromDetail TransferFromDetail { get; set; }
    public TransferToDetail TransferToDetail { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.MARKETPLACE_CREATETRANSFER_PATH;
    }
    
    public override void validate()
    {
           
    }
}