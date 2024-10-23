using ams_dotnet.com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.marketplace;

public class AlipayRegisterRequest:AMSRequest<AlipayRegisterResponse>
{
    public string RegistrationRequestId { get; set; }
    public SettlementInfo[] SettlementInfos { get; set; }
    public MerchantInfo MerchantInfo { get; set; }
    public PaymentMethod[] PaymentMethods { get; set; }
    
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.MARKETPLACE_REGISTER_PATH;
    }
    
    public override void validate()
    {
           
    }
}