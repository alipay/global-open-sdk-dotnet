using com.alipay.ams.api.response.marketplace;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.request.marketplace
{

public class AlipaySubmitAttachmentRequest : AMSRequest<AlipaySubmitAttachmentResponse>
    {

        public AlipaySubmitAttachmentRequest() { }

        public AlipaySubmitAttachmentRequest( string submitAttachmentRequestId , AttachmentType attachmentType , string fileSha256)
        {
            this.SubmitAttachmentRequestId = submitAttachmentRequestId;
            this.AttachmentType = attachmentType;
            this.FileSha256 = fileSha256;
        }

            public string SubmitAttachmentRequestId { get; set; }
            public AttachmentType AttachmentType { get; set; }
            public string FileSha256 { get; set; }

        public override string GetRequestURI(){ 
    return "/ams/api/open/openapiv2_file/v1/business/attachment/submitAttachment"; 
} 


    }

}
