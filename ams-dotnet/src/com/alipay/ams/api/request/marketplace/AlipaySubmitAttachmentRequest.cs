using ams_dotnet.com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.request.marketplace;

public class AlipaySubmitAttachmentRequest:AMSRequest<AlipaySubmitAttachmentResponse>
{
    public string SubmitAttachmentRequestId { get; set; }
    public AttachmentType AttachmentType { get; set; }
    public string FileSha256 { get; set; }
    
    public override string GetRequestURI()
    {
        return AntomPathConstants.MARKETPLACE_SUBMITATTACHMENT_PATH;
    }
    
    public override void validate()
    {
           
    }
}