using ams_dotnet.com.alipay.ams.api.response.vaulting;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.vaulting;

public class AlipayVaultingPaymentMethodRequest:AMSRequest<AlipayVaultingPaymentMethodResponse>
{
    public string VaultingRequestId { get; set; }
    public string VaultingNotificationUrl { get; set; }
    public string RedirectUrl { get; set; }
    public string MerchantRegion { get; set; }
    public PaymentMethodDetail PaymentMethodDetail { get; set; }
    public Env Env { get; set; }
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.VAULT_PAYMENT_METHOD_PATH;
    }
    
    public override void validate()
    {
           
    }
}