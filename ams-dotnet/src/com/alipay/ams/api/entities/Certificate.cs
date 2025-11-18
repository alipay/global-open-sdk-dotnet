using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Certificate
    {

        public Certificate() { }

        

        public Certificate( CertificateType certificateType , string certificateNo , UserName holderName , List<string> fileKeys , string certificateAuthority)
        {
            this.CertificateType = certificateType;
            this.CertificateNo = certificateNo;
            this.HolderName = holderName;
            this.FileKeys = fileKeys;
            this.CertificateAuthority = certificateAuthority;
        }

            public CertificateType CertificateType { get; set; }
            public string CertificateNo { get; set; }
            public UserName HolderName { get; set; }
            public List<string> FileKeys { get; set; }
            public string CertificateAuthority { get; set; }

        

    }

}
