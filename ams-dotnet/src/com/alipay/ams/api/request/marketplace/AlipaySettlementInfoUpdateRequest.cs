using ams_dotnet.com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;

namespace com.alipay.ams.api.request.marketplace;

public class AlipaySettlementInfoUpdateRequest:AMSRequest<AlipaySettlementInfoUpdateResponse>
{
    public string UpdateRequestId { get; set; }
    public string ReferenceMerchantId { get; set; }
    public string SettlementCurrency { get; set; }
    public SettlementBankAccount SettlementBankAccount { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.MARKETPLACE_SETTLEMENTINFO_UPDATE_PATH;
    }
    
    public override void validate()
    {
           
    }
}