using com.alipay.ams.api.response;

namespace com.alipay.ams.api.request
{
    /// <summary>
    /// Base request accepted only by DefaultAlipayClient.UploadFile.
    /// </summary>
    public abstract class AMSFileRequest<TAMSResponse>
        where TAMSResponse : AMSResponse
    {
        public AlipayFileContent File { get; set; }

        public string KeyVersion { get; set; }
    }
}
