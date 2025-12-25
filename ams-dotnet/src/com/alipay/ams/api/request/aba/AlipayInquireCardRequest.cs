using com.alipay.ams.api.response.aba;
using com.alipay.ams.api.request;
using com.alipay.ams.api.entities;
using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.request.aba
{

public class AlipayInquireCardRequest : AMSRequest<AlipayInquireCardResponse>
    {

        public AlipayInquireCardRequest() { }

        

        public AlipayInquireCardRequest( int? pageNumber , int? pageSize , string lastFourDigits , string cardStatus , string cardNickName)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.LastFourDigits = lastFourDigits;
            this.CardStatus = cardStatus;
            this.CardNickName = cardNickName;
        }

            public int? PageNumber { get; set; }
            public int? PageSize { get; set; }
            public string LastFourDigits { get; set; }
            public string CardStatus { get; set; }
            public string CardNickName { get; set; }

        public override string GetRequestURI(){ return "/ams/api/v1/aba/cards/inquireCard"; } 


    }

}
