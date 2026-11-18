using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquiryBalanceResponse : AMSResponse
    {

        public AlipayInquiryBalanceResponse() { }

        

        public AlipayInquiryBalanceResponse( AccountBalance[] accountBalances , Result result)
        {
            this.AccountBalances = accountBalances;
            this.Result = result;
        }

            public AccountBalance[] AccountBalances { get; set; }
            public Result Result { get; set; }

        

    }

}
