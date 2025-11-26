using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ThreeDSResult
    {

        public ThreeDSResult() { }

        

        public ThreeDSResult( string threeDSVersion , string eci , string cavv , string dsTransactionId , string xid , string threeDStransactionStatusReason , string challengeCancel , bool? challenged , string exemptionType , bool? threeDSOffered)
        {
            this.ThreeDSVersion = threeDSVersion;
            this.Eci = eci;
            this.Cavv = cavv;
            this.DsTransactionId = dsTransactionId;
            this.Xid = xid;
            this.ThreeDStransactionStatusReason = threeDStransactionStatusReason;
            this.ChallengeCancel = challengeCancel;
            this.Challenged = challenged;
            this.ExemptionType = exemptionType;
            this.ThreeDSOffered = threeDSOffered;
        }

            public string ThreeDSVersion { get; set; }
            public string Eci { get; set; }
            public string Cavv { get; set; }
            public string DsTransactionId { get; set; }
            public string Xid { get; set; }
            public string ThreeDStransactionStatusReason { get; set; }
            public string ChallengeCancel { get; set; }
            public bool? Challenged { get; set; }
            public string ExemptionType { get; set; }
            public bool? ThreeDSOffered { get; set; }

        

    }

}
