using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardVerificationResult
    {

        public CardVerificationResult() { }

        

        public CardVerificationResult(  string  authenticationType ,  string  authenticationMethod ,  string  cvvResult ,  string  avsResult ,  string  authorizationCode ,  RiskThreeDSResult  threeDSResult)
        {
            this.AuthenticationType = authenticationType;
            this.AuthenticationMethod = authenticationMethod;
            this.CvvResult = cvvResult;
            this.AvsResult = avsResult;
            this.AuthorizationCode = authorizationCode;
            this.ThreeDSResult = threeDSResult;
        }

            public  string  AuthenticationType { get; set; }
            public  string  AuthenticationMethod { get; set; }
            public  string  CvvResult { get; set; }
            public  string  AvsResult { get; set; }
            public  string  AuthorizationCode { get; set; }
            public  RiskThreeDSResult  ThreeDSResult { get; set; }

        

    }

}
