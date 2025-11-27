using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class MpiData
    {

        public MpiData() { }

        

        public MpiData( string threeDSVersion , string eci , string cavv , string dsTransactionId , string credentialType)
        {
            this.ThreeDSVersion = threeDSVersion;
            this.Eci = eci;
            this.Cavv = cavv;
            this.DsTransactionId = dsTransactionId;
            this.CredentialType = credentialType;
        }

            public string ThreeDSVersion { get; set; }
            public string Eci { get; set; }
            public string Cavv { get; set; }
            public string DsTransactionId { get; set; }
            public string CredentialType { get; set; }

        

    }

}
