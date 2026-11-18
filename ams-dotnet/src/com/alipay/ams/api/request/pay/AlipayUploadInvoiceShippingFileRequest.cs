using ams_dotnet.com.alipay.ams.api.response.pay;

namespace com.alipay.ams.api.request;

public class AlipayUploadInvoiceShippingFileRequest  : AMSRequest<AlipayUploadInvoiceShippingFileResponse>
{
    private string PaymentRequestId { get; set; }
    private string FileId { get; set; }
    private string UploadFile { get; set; }
    private string FileType { get; set; }
    private string FileName { get; set; }
    
    public override string GetRequestURI()
    {
        return "/ams/api/v1/payments/uploadInvoiceShippingFile";
    }

    public override void validate()
    {
           
    }
}