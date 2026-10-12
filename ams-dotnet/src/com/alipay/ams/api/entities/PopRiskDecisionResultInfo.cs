using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class PopRiskDecisionResultInfo
    {

        public PopRiskDecisionResultInfo() { }

        

        public PopRiskDecisionResultInfo( string riskAuthDecision , string riskDecision , string postRiskDecision)
        {
            this.RiskAuthDecision = riskAuthDecision;
            this.RiskDecision = riskDecision;
            this.PostRiskDecision = postRiskDecision;
        }

            public string RiskAuthDecision { get; set; }
            public string RiskDecision { get; set; }
            public string PostRiskDecision { get; set; }

        

    }

}
