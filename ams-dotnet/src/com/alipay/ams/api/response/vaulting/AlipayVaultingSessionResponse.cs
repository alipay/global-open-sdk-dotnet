using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.vaulting;

public class AlipayVaultingSessionResponse:AMSResponse
{
    public string VaultingSessionData { get; set; }
    public string VaultingSessionId { get; set; }
    public string VaultingSessionExpiryTime { get; set; }
}