using ams_dotnet.com.alipay.ams.api.response.pay;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request;

public class AlipaySyncArrearRequest : AMSRequest<AlipaySyncArrearResponse>
{
    public string PaymentId { get; set; }
    public string PaymentRequestId { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.SYNC_ARREAR_PATH;
    }

    public override void validate()
    {
           
    }
}