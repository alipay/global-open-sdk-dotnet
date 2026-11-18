using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayCancelRuleResponse : AMSResponse
    {

        public AlipayCancelRuleResponse() { }

        

        public AlipayCancelRuleResponse( Result result , string ruleId , string merchantId , FundsType fundsType , TakeType takeType , PaymentMethodScope paymentMethodScope , int? ratio , ReleaseType releaseType , string releaseTime , int? retentionTime , RuleStatus ruleStatus , string createTime , string updateTime)
        {
            this.Result = result;
            this.RuleId = ruleId;
            this.MerchantId = merchantId;
            this.FundsType = fundsType;
            this.TakeType = takeType;
            this.PaymentMethodScope = paymentMethodScope;
            this.Ratio = ratio;
            this.ReleaseType = releaseType;
            this.ReleaseTime = releaseTime;
            this.RetentionTime = retentionTime;
            this.RuleStatus = ruleStatus;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

            public Result Result { get; set; }
            public string RuleId { get; set; }
            public string MerchantId { get; set; }
            public FundsType FundsType { get; set; }
            public TakeType TakeType { get; set; }
            public PaymentMethodScope PaymentMethodScope { get; set; }
            public int? Ratio { get; set; }
            public ReleaseType ReleaseType { get; set; }
            public string ReleaseTime { get; set; }
            public int? RetentionTime { get; set; }
            public RuleStatus RuleStatus { get; set; }
            public string CreateTime { get; set; }
            public string UpdateTime { get; set; }

        

    }

}
