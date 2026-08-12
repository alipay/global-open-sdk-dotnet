using System.IO;

namespace com.alipay.ams.api.request
{
    /// <summary>
    /// Caller-owned file content used by an SDK-provided file request.
    /// </summary>
    public sealed class AlipayFileContent
    {
        public Stream Stream { get; set; }

        public string FileName { get; set; }

        public string ContentType { get; set; }
    }
}
