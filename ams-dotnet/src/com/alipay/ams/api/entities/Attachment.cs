using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class Attachment
    {

        public Attachment() { }

        

        public Attachment( AttachmentType attachmentType , string file , string attachmentName , string fileKey)
        {
            this.AttachmentType = attachmentType;
            this.File = file;
            this.AttachmentName = attachmentName;
            this.FileKey = fileKey;
        }

            public AttachmentType AttachmentType { get; set; }
            public string File { get; set; }
            public string AttachmentName { get; set; }
            public string FileKey { get; set; }

        

    }

}
