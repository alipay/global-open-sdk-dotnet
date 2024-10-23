using ams_dotnet.com.alipay.ams.api.response.dispute;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.dispute;

public class AlipaySupplyDefenseDocumentRequest:AMSRequest<AlipaySupplyDefenseDocumentResponse>
{
    public string DisputeId { get; set; }
    public string DisputeEvidence { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.SUPPLY_DEFENCE_DOC_PATH;
    }
    
    
    public override void validate()
    {
           
    }
    
}