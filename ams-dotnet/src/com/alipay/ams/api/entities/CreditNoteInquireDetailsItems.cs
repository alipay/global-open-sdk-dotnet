using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CreditNoteInquireDetailsItems
    {

        public CreditNoteInquireDetailsItems() { }

        

        public CreditNoteInquireDetailsItems( List<LineItem> data , bool? hasMore)
        {
            this.Data = data;
            this.HasMore = hasMore;
        }

            public List<LineItem> Data { get; set; }
            public bool? HasMore { get; set; }

        

    }

}
