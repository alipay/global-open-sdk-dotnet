using ams_dotnet.com.alipay.ams.api.response.dispute;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.dispute;

public class AlipayAcceptDisputeRequest:AMSRequest<AlipayAcceptDisputeResponse>
{
    public string DisputeId { get; set; }
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.ACCEPT_DISPUTE_PATH;
    }
    
    public override void validate()
    {
           
    }
}