using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayProductUploadImageResponse : AMSResponse
    {

        public AlipayProductUploadImageResponse() { }

        

        public AlipayProductUploadImageResponse( Result result , string imageUrl , string imageName)
        {
            this.Result = result;
            this.ImageUrl = imageUrl;
            this.ImageName = imageName;
        }

            public Result Result { get; set; }
            public string ImageUrl { get; set; }
            public string ImageName { get; set; }

        

    }

}
