using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.vaulting;

public class AlipayVaultingPaymentMethodResponse:AMSResponse
{
    public string VaultingRequestId { get; set; }

    public PaymentMethodDetail PaymentMethodDetail { get; set; }

    public string NormalUrl { get; set; }

    public string SchemeUrl { get; set; }

    public string ApplinkUrl { get; set; }
}