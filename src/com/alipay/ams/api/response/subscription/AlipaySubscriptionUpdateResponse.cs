using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.subscription
{

public class AlipaySubscriptionUpdateResponse : AMSResponse
    {

        public AlipaySubscriptionUpdateResponse() { }

        public AlipaySubscriptionUpdateResponse( Result result)
        {
            this.Result = result;
        }

            public Result Result { get; set; }

        

    }

}
