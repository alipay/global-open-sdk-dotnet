using ams_dotnet.com.alipay.ams.api.response.vaulting;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.vaulting;

public class AlipayVaultingQueryRequest:AMSRequest<AlipayVaultingQueryResponse>
{
    public string VaultingRequestId { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.INQUIRE_VAULTING_PATH;
    }
    
    public override void validate()
    {
           
    }
}