using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Paginator
    {

        public Paginator() { }

        

        public Paginator( int? currentPage , int? pageSize , int? totalPage , int? totalCount)
        {
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.TotalPage = totalPage;
            this.TotalCount = totalCount;
        }

            public int? CurrentPage { get; set; }
            public int? PageSize { get; set; }
            public int? TotalPage { get; set; }
            public int? TotalCount { get; set; }

        

    }

}
