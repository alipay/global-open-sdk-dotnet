    
namespace com.alipay.ams.api.entities
{

public class WebSite
    {

        public WebSite() { }

        public WebSite( string name , string url , string desc , string type)
        {
            this.Name = name;
            this.Url = url;
            this.Desc = desc;
            this.Type = type;
        }

            public string Name { get; set; }
            public string Url { get; set; }
            public string Desc { get; set; }
            public string Type { get; set; }

        

    }

}
