using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class TotalCount
    {

        public TotalCount() { }

        

        public TotalCount( string totalPageNumber , string currentPageNumber)
        {
            this.TotalPageNumber = totalPageNumber;
            this.CurrentPageNumber = currentPageNumber;
        }

            public string TotalPageNumber { get; set; }
            public string CurrentPageNumber { get; set; }

        

    }

}
