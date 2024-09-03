using System.Collections.Generic;

namespace com.alipay.ams.api.entities
{
    public class Certificate
    {
        public CertificateType CertificateType { get; set; }
        public string CertificateNo  { get; set; }
        public UserName HolderName  { get; set; }
        public List<string> FileKeys  { get; set; }
        public string CertificateAuthority  { get; set; }
    }
}