using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Service
    {

        public Service() { }

        

        public Service( string categoryCode , string subCategoryCode)
        {
            this.CategoryCode = categoryCode;
            this.SubCategoryCode = subCategoryCode;
        }

            public string CategoryCode { get; set; }
            public string SubCategoryCode { get; set; }

        

    }

}
