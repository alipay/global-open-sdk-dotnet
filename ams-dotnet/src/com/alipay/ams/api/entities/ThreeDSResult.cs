using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ThreeDSResult
    {

        public ThreeDSResult() { }

        

        public ThreeDSResult(  string  threeDSVersion ,  string  eci ,  string  cavv ,  string  dsTransactionId ,  string  xid)
        {
            this.ThreeDSVersion = threeDSVersion;
            this.Eci = eci;
            this.Cavv = cavv;
            this.DsTransactionId = dsTransactionId;
            this.Xid = xid;
        }

            public  string  ThreeDSVersion { get; set; }
            public  string  Eci { get; set; }
            public  string  Cavv { get; set; }
            public  string  DsTransactionId { get; set; }
            public  string  Xid { get; set; }

        

    }

}
