using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayCancelRuleRequest : AMSRequest<AlipayCancelRuleResponse>
    {

        public AlipayCancelRuleRequest() { }

        

        public AlipayCancelRuleRequest( string ruleId)
        {
            this.RuleId = ruleId;
        }

            public string RuleId { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/cancelRule"; } 


    }

}
