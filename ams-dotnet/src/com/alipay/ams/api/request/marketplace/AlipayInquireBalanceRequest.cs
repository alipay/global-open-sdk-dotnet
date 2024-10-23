using ams_dotnet.com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.marketplace;

public class AlipayInquireBalanceRequest:AMSRequest<AlipayInquireBalanceResponse>
{

    public string ReferenceMerchantId { get; set; }

    public override string GetRequestURI()
    {
        return AntomPathConstants.MARKETPLACE_INQUIREBALANCE_PATH;
    }
    
    public override void validate()
    {
           
    }
    
}