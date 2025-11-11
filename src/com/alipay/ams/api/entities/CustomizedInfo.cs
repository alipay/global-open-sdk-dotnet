    
namespace com.alipay.ams.api.entities
{

public class CustomizedInfo
    {

        public CustomizedInfo() { }

        public CustomizedInfo( string customizedField1 , string customizedField2 , string customizedField3 , string customizedField4 , string customizedField5)
        {
            this.CustomizedField1 = customizedField1;
            this.CustomizedField2 = customizedField2;
            this.CustomizedField3 = customizedField3;
            this.CustomizedField4 = customizedField4;
            this.CustomizedField5 = customizedField5;
        }

            public string CustomizedField1 { get; set; }
            public string CustomizedField2 { get; set; }
            public string CustomizedField3 { get; set; }
            public string CustomizedField4 { get; set; }
            public string CustomizedField5 { get; set; }

        

    }

}
