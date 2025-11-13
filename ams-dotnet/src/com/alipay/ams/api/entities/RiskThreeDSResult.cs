using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class RiskThreeDSResult
    {

        public RiskThreeDSResult() { }

        

        public RiskThreeDSResult(  string  threeDSVersion ,  string  threeDSInteractionMode ,  string  eci ,  string  cavv)
        {
            this.ThreeDSVersion = threeDSVersion;
            this.ThreeDSInteractionMode = threeDSInteractionMode;
            this.Eci = eci;
            this.Cavv = cavv;
        }

            public  string  ThreeDSVersion { get; set; }
            public  string  ThreeDSInteractionMode { get; set; }
            public  string  Eci { get; set; }
            public  string  Cavv { get; set; }

        

    }

}
