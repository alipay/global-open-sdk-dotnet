using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class BusinessInfo
    {

        public BusinessInfo() { }

        

        public BusinessInfo(  string  mcc ,  List<WebSite>  websites ,  string  englishName ,  string  doingBusinessAs ,  string  mainSalesCountry ,  string  appName ,  string  serviceDescription)
        {
            this.Mcc = mcc;
            this.Websites = websites;
            this.EnglishName = englishName;
            this.DoingBusinessAs = doingBusinessAs;
            this.MainSalesCountry = mainSalesCountry;
            this.AppName = appName;
            this.ServiceDescription = serviceDescription;
        }

            public  string  Mcc { get; set; }
            public  List<WebSite>  Websites { get; set; }
            public  string  EnglishName { get; set; }
            public  string  DoingBusinessAs { get; set; }
            public  string  MainSalesCountry { get; set; }
            public  string  AppName { get; set; }
            public  string  ServiceDescription { get; set; }

        

    }

}
