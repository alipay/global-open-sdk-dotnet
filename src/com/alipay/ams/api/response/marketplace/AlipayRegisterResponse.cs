using com.alipay.ams.api.entities;
    
namespace com.alipay.ams.api.response.marketplace
{

public class AlipayRegisterResponse : AMSResponse
    {

        public AlipayRegisterResponse() { }

        public AlipayRegisterResponse( Result result , string registrationStatus)
        {
            this.Result = result;
            this.RegistrationStatus = registrationStatus;
        }

            public Result Result { get; set; }
            public string RegistrationStatus { get; set; }

        

    }

}
