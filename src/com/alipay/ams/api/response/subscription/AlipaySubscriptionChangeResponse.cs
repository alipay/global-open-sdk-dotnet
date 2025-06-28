using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipaySubscriptionChangeResponse : AMSResponse
    {

        public AlipaySubscriptionChangeResponse() { }

        public AlipaySubscriptionChangeResponse( Result result)
        {
            this.Result = result;
        }

            public Result Result { get; set; }

        

    }

}
