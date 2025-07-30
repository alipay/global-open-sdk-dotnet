    
namespace com.alipay.ams.api.entities
{

public class Logo
    {

        public Logo() { }

        public Logo( string logoName , string logoUrl)
        {
            this.LogoName = logoName;
            this.LogoUrl = logoUrl;
        }

            public string LogoName { get; set; }
            public string LogoUrl { get; set; }

        

    }

}
