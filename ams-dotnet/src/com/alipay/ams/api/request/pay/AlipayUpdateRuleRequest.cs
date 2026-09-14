using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayUpdateRuleRequest : AMSRequest<AlipayUpdateRuleResponse>
    {

        public AlipayUpdateRuleRequest() { }

        

        public AlipayUpdateRuleRequest( string ruleId , PaymentMethodScope paymentMethodScope , int? ratio , string releaseTime , int? retentionTime , RuleStatus ruleStatus)
        {
            this.RuleId = ruleId;
            this.PaymentMethodScope = paymentMethodScope;
            this.Ratio = ratio;
            this.ReleaseTime = releaseTime;
            this.RetentionTime = retentionTime;
            this.RuleStatus = ruleStatus;
        }

            public string RuleId { get; set; }
            public PaymentMethodScope PaymentMethodScope { get; set; }
            public int? Ratio { get; set; }
            public string ReleaseTime { get; set; }
            public int? RetentionTime { get; set; }
            public RuleStatus RuleStatus { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/updateRule"; } 


    }

}
