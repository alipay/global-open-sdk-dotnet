using com.alipay.ams.api.entities;
using com.alipay.ams.api.response;

namespace ams_dotnet.com.alipay.ams.api.response.marketplace;

public class AlipaySubmitAttachmentResponse:AMSResponse
{
    public string SubmitAttachmentRequestId { get; set; }
    public AttachmentType AttachmentType { get; set; }
    public string AttachmentKey { get; set; }
}