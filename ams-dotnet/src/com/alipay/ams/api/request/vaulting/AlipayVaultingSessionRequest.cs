using ams_dotnet.com.alipay.ams.api.response.vaulting;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.vaulting;

public class AlipayVaultingSessionRequest:AMSRequest<AlipayVaultingSessionResponse>
{
    public string PaymentMethodType { get; set; }

    public string VaultingRequestId { get; set; }

    public string VaultingNotificationUrl { get; set; }

    public string RedirectUrl { get; set; }

    public string MerchantRegion  { get; set; }

    public bool Is3DSAuthentication { get; set; }
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.CREATE_VAULTING_SESSION_PATH;
    }
    
    public override void validate()
    {
           
    }
}