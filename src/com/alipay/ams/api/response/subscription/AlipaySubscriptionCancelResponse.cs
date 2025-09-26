using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipaySubscriptionCancelResponse : AMSResponse
    {

        public AlipaySubscriptionCancelResponse() { }

        public AlipaySubscriptionCancelResponse( Result result)
        {
            this.Result = result;
        }

            public Result Result { get; set; }

        

    }

}
