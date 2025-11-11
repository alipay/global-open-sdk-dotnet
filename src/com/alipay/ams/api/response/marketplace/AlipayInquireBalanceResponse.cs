using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.marketplace
{

public class AlipayInquireBalanceResponse : AMSResponse
    {

        public AlipayInquireBalanceResponse() { }

        public AlipayInquireBalanceResponse( Result result , List<AccountBalance> accountBalances)
        {
            this.Result = result;
            this.AccountBalances = accountBalances;
        }

            public Result Result { get; set; }
            public List<AccountBalance> AccountBalances { get; set; }

        

    }

}
