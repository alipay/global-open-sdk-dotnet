using ams_dotnet.com.alipay.ams.api.response.pay;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request;

public class AlipayRetrievePaymentSessionRequest : AMSRequest<AlipayRetrievePaymentSessionResponse>
{
    public string PaymentRequestId { get; set; }
    
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.RETRIEVE_PATH;
    }
    
    
    public override void validate()
    {
    }

}