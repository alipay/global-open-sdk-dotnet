using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.pay
{

public class AlipayInquireRuleListResponse : AMSResponse
    {

        public AlipayInquireRuleListResponse() { }

        

        public AlipayInquireRuleListResponse( Result result , bool? hasMore , List<ReserveRule> rules)
        {
            this.Result = result;
            this.HasMore = hasMore;
            this.Rules = rules;
        }

            public Result Result { get; set; }
            public bool? HasMore { get; set; }
            public List<ReserveRule> Rules { get; set; }

        

    }

}
