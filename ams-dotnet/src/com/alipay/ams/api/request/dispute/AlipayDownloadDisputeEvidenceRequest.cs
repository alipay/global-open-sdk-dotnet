using ams_dotnet.com.alipay.ams.api.response.dispute;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.dispute;

public class AlipayDownloadDisputeEvidenceRequest:AMSRequest<AlipayDownloadDisputeEvidenceResponse>
{
    public string DisputeId { get; set; }
    public DisputeEvidenceType DisputeEvidenceType { get; set; }
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.DOWNLOAD_DISPUTE_EVIDENCE_PATH;
    }
    
    public override void validate()
    {
           
    }
}