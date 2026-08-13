using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.billing
{

public class AlipayProductUploadImageResponse : AMSResponse
    {

        public AlipayProductUploadImageResponse() { }

        

        public AlipayProductUploadImageResponse(Result result, string imageUrl, string imageName, string productId)
        {
            this.Result = result;
            this.ImageUrl = imageUrl;
            this.ImageName = imageName;
            this.ProductId = productId;
        }

            public string ImageUrl { get; set; }
            public string ImageName { get; set; }
            public string ProductId { get; set; }

        

    }

}
