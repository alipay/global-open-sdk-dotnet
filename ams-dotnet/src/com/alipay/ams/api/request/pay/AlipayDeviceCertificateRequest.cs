using ams_dotnet.com.alipay.ams.api.response.pay;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request;

public class AlipayDeviceCertificateRequest : AMSRequest<AlipayDeviceCertificateResponse>
{
    public string DevicePublicKey { get; set; }
    
    public string DeviceRequestId { get; set; }

    public override string GetRequestURI()
    {
        return AntomPathConstants.CREATE_DEVICE_CERTIFICATE_PATH;
    }

    public override void validate()
    {
           
    }
}