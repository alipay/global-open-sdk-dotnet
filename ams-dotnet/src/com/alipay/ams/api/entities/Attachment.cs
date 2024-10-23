﻿using System;
namespace com.alipay.ams.api.entities
{
    public class Attachment
    {
        public AttachmentType AttachmentType { get; set; }

        public string File { get; set; }

        public string AttachmentName { get; set; }
        
        public string FileKey { get; set; }
    }
}
