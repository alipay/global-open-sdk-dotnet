using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class AbaCard
    {

        public AbaCard() { }

        

        public AbaCard( string assetId , string cardNickName , string maskedCardNo , string cardStatus , string cardBrand , string createdTime , string updatedTime)
        {
            this.AssetId = assetId;
            this.CardNickName = cardNickName;
            this.MaskedCardNo = maskedCardNo;
            this.CardStatus = cardStatus;
            this.CardBrand = cardBrand;
            this.CreatedTime = createdTime;
            this.UpdatedTime = updatedTime;
        }

            public string AssetId { get; set; }
            public string CardNickName { get; set; }
            public string MaskedCardNo { get; set; }
            public string CardStatus { get; set; }
            public string CardBrand { get; set; }
            public string CreatedTime { get; set; }
            public string UpdatedTime { get; set; }

        

    }

}
