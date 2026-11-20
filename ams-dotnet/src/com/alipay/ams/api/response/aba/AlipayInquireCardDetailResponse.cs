using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.response.aba
{

public class AlipayInquireCardDetailResponse : AMSResponse
    {

        public AlipayInquireCardDetailResponse() { }

        

        public AlipayInquireCardDetailResponse( Result result , string assetId , string cardNickName , string cardStatus , string maskedCardNo , string cardBrand , string createdTime , string updatedTime , string purpose , string note , Dictionary<string, string> metadata , AuthorizationControl authorizationControl , CardholderInfo cardholderinfo)
        {
            this.Result = result;
            this.AssetId = assetId;
            this.CardNickName = cardNickName;
            this.CardStatus = cardStatus;
            this.MaskedCardNo = maskedCardNo;
            this.CardBrand = cardBrand;
            this.CreatedTime = createdTime;
            this.UpdatedTime = updatedTime;
            this.Purpose = purpose;
            this.Note = note;
            this.Metadata = metadata;
            this.AuthorizationControl = authorizationControl;
            this.Cardholderinfo = cardholderinfo;
        }

            public Result Result { get; set; }
            public string AssetId { get; set; }
            public string CardNickName { get; set; }
            public string CardStatus { get; set; }
            public string MaskedCardNo { get; set; }
            public string CardBrand { get; set; }
            public string CreatedTime { get; set; }
            public string UpdatedTime { get; set; }
            public string Purpose { get; set; }
            public string Note { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
            public AuthorizationControl AuthorizationControl { get; set; }
            public CardholderInfo Cardholderinfo { get; set; }

        

    }

}
