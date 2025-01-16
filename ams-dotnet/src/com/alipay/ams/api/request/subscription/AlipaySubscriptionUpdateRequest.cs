using ams_dotnet.com.alipay.ams.api.response.subscription;
using com.alipay.ams.api.entities;
using com.alipay.ams.api.request;

namespace ams_dotnet.com.alipay.ams.api.request.subscription;

public class AlipaySubscriptionUpdateRequest : AMSRequest<AlipaySubscriptionUpdateResponse>
{
    public string SubscriptionUpdateRequestId { get; set; }
    public string SubscriptionId { get; set; }
    public string SubscriptionDescription { get; set; }
    public PeriodRule PeriodRule { get; set; }
    public Amount PaymentAmount { get; set; }
    public string SubscriptionEndTime { get; set; }
    public OrderInfo OrderInfo { get; set; }
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.SUBSCRIPTION_UPDATE_PATH;
    }

    public override void validate()
    {
            
    }
}