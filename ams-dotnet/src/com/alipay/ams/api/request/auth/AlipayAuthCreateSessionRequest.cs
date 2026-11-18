

using com.alipay.ams.api.entities;
using com.alipay.ams.api.response.auth;

namespace com.alipay.ams.api.request.auth;

public class AlipayAuthCreateSessionRequest : AMSRequest<AlipayAuthCreateSessionResponse>
{
    public ProductCodeType ProductCode { get; set; }
    public AgreementInfo AgreementInfo { get; set; }
    public ScopeType[] Scopes { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public string PaymentRedirectUrl { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.CREATE_SESSION_PATH;
    }

    public override void validate()
    {
    }
}