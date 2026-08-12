using com.alipay.ams.api.response.billing;

namespace com.alipay.ams.api.request.billing
{
    /// <summary>
    /// Request for uploading an image that can later be associated with a product.
    /// </summary>
    public sealed class AlipayProductUploadImageRequest
        : AMSFileRequest<AlipayProductUploadImageResponse>
    {
        public AlipayProductUploadImageRequest()
        {
        }

        public AlipayProductUploadImageRequest(string productId, AlipayFileContent file)
        {
            ProductId = productId;
            File = file;
        }

        public string ProductId { get; set; }
    }
}
