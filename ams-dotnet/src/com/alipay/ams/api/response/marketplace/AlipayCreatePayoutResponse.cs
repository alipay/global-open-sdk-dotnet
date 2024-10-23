using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.marketplace;

public class AlipayCreatePayoutResponse:AMSResponse
{
    public string TransferId { get; set; }
    public string TransferRequestId { get; set; }
    public TransferFromDetail TransferFromDetail { get; set; }
    public TransferToDetail TransferToDetail { get; set; }
}