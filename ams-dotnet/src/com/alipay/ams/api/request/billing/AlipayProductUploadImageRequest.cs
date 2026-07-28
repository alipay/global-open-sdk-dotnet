using com.alipay.ams.api.response.billing;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.billing
{

public class AlipayProductUploadImageRequest : AMSRequest<AlipayProductUploadImageResponse>
    {

        public AlipayProductUploadImageRequest() { }

        

        public AlipayProductUploadImageRequest( string productId , string imageFile)
        {
            this.ProductId = productId;
            this.ImageFile = imageFile;
        }

            public string ProductId { get; set; }
            public string ImageFile { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/billing/product/uploadImage"; } 


    }

}
