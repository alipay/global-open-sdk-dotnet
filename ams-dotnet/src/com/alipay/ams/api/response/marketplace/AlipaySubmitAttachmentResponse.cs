using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.marketplace
{

public class AlipaySubmitAttachmentResponse : AMSResponse
    {

        public AlipaySubmitAttachmentResponse() { }

        

        public AlipaySubmitAttachmentResponse( Result result , string submitAttachmentRequestId , AttachmentType attachmentType , string attachmentKey)
        {
            this.Result = result;
            this.SubmitAttachmentRequestId = submitAttachmentRequestId;
            this.AttachmentType = attachmentType;
            this.AttachmentKey = attachmentKey;
        }

            public Result Result { get; set; }
            public string SubmitAttachmentRequestId { get; set; }
            public AttachmentType AttachmentType { get; set; }
            public string AttachmentKey { get; set; }

        

    }

}
