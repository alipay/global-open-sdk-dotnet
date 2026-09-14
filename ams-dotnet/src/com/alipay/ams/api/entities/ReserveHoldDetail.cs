using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class ReserveHoldDetail
    {

        public ReserveHoldDetail() { }

        

        public ReserveHoldDetail( string holdRequestId , string holdId , Amount holdAmount , Amount releasableAmount , string releaseTime , string holdStatus , string releaseStatus)
        {
            this.HoldRequestId = holdRequestId;
            this.HoldId = holdId;
            this.HoldAmount = holdAmount;
            this.ReleasableAmount = releasableAmount;
            this.ReleaseTime = releaseTime;
            this.HoldStatus = holdStatus;
            this.ReleaseStatus = releaseStatus;
        }

            public string HoldRequestId { get; set; }
            public string HoldId { get; set; }
            public Amount HoldAmount { get; set; }
            public Amount ReleasableAmount { get; set; }
            public string ReleaseTime { get; set; }
            public string HoldStatus { get; set; }
            public string ReleaseStatus { get; set; }

        

    }

}
