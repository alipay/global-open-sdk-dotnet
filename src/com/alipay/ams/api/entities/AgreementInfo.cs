    
namespace com.alipay.ams.api.entities
{

public class AgreementInfo
    {

        public AgreementInfo() { }

        public AgreementInfo( string authState , string userLoginId , string userLoginType , string displayUserLoginId)
        {
            this.AuthState = authState;
            this.UserLoginId = userLoginId;
            this.UserLoginType = userLoginType;
            this.DisplayUserLoginId = displayUserLoginId;
        }

            public string AuthState { get; set; }
            public string UserLoginId { get; set; }
            public string UserLoginType { get; set; }
            public string DisplayUserLoginId { get; set; }

        

    }

}
