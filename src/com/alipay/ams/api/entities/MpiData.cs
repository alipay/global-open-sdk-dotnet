    
namespace com.alipay.ams.api.entities
{

public class MpiData
    {

        public MpiData() { }

        public MpiData( string threeDSVersion , string eci , string cavv , string dsTransactionId)
        {
            this.ThreeDSVersion = threeDSVersion;
            this.Eci = eci;
            this.Cavv = cavv;
            this.DsTransactionId = dsTransactionId;
        }

            public string ThreeDSVersion { get; set; }
            public string Eci { get; set; }
            public string Cavv { get; set; }
            public string DsTransactionId { get; set; }

        

    }

}
