using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class FundMoveDetail
    {

        public FundMoveDetail() { }

        

        public FundMoveDetail( string payerName , string payerAccountNo , string payerChaneelAccountnumber , string payerAccountType , string payerAssetId , string beneficiaryName , string beneficiaryAccountType , string beneficiaryBankCountry , string beneficiaryBankName , string beneficiaryAssetId , string remarks , string description , string memo , string referenceTransactionId)
        {
            this.PayerName = payerName;
            this.PayerAccountNo = payerAccountNo;
            this.PayerChaneelAccountnumber = payerChaneelAccountnumber;
            this.PayerAccountType = payerAccountType;
            this.PayerAssetId = payerAssetId;
            this.BeneficiaryName = beneficiaryName;
            this.BeneficiaryAccountType = beneficiaryAccountType;
            this.BeneficiaryBankCountry = beneficiaryBankCountry;
            this.BeneficiaryBankName = beneficiaryBankName;
            this.BeneficiaryAssetId = beneficiaryAssetId;
            this.Remarks = remarks;
            this.Description = description;
            this.Memo = memo;
            this.ReferenceTransactionId = referenceTransactionId;
        }

            public string PayerName { get; set; }
            public string PayerAccountNo { get; set; }
            public string PayerChaneelAccountnumber { get; set; }
            public string PayerAccountType { get; set; }
            public string PayerAssetId { get; set; }
            public string BeneficiaryName { get; set; }
            public string BeneficiaryAccountType { get; set; }
            public string BeneficiaryBankCountry { get; set; }
            public string BeneficiaryBankName { get; set; }
            public string BeneficiaryAssetId { get; set; }
            public string Remarks { get; set; }
            public string Description { get; set; }
            public string Memo { get; set; }
            public string ReferenceTransactionId { get; set; }

        

    }

}
