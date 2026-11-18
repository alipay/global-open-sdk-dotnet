using com.alipay.ams.api.response.pay;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.pay
{

public class AlipayCreateRuleRequest : AMSRequest<AlipayCreateRuleResponse>
    {

        public AlipayCreateRuleRequest() { }

        

        public AlipayCreateRuleRequest( FundsType fundsType , TakeType takeType , PaymentMethodScope paymentMethodScope , int? ratio , ReleaseType releaseType , string releaseTime , int? retentionTime)
        {
            this.FundsType = fundsType;
            this.TakeType = takeType;
            this.PaymentMethodScope = paymentMethodScope;
            this.Ratio = ratio;
            this.ReleaseType = releaseType;
            this.ReleaseTime = releaseTime;
            this.RetentionTime = retentionTime;
        }

            public FundsType FundsType { get; set; }
            public TakeType TakeType { get; set; }
            public PaymentMethodScope PaymentMethodScope { get; set; }
            public int? Ratio { get; set; }
            public ReleaseType ReleaseType { get; set; }
            public string ReleaseTime { get; set; }
            public int? RetentionTime { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/payments/reserve/createRule"; } 


    }

}
