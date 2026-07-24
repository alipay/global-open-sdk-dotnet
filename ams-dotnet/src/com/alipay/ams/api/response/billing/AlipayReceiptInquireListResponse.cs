using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayReceiptInquireListResponse : AMSResponse
    {

        public AlipayReceiptInquireListResponse() { }

        

        public AlipayReceiptInquireListResponse( Result result , List<Receipt> receipts , int? total , bool? hasMore , string nextCursor)
        {
            this.Result = result;
            this.Receipts = receipts;
            this.Total = total;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

            public Result Result { get; set; }
            public List<Receipt> Receipts { get; set; }
            public int? Total { get; set; }
            public bool? HasMore { get; set; }
            public string NextCursor { get; set; }

        

    }

}
