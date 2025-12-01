using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class CardPaymentMethodDetail
    {

        public CardPaymentMethodDetail() { }

        

        public CardPaymentMethodDetail( string supportedBrands , string cardToken , string cardNo , CardBrand brand , CardBrand selectedCardBrand , string cardIssuer , string countryIssue , UserName instUserName , string expiryYear , string expiryMonth , Address billingAddress , string mask , string last4 , string paymentMethodDetailMetadata , string maskedCardNo , string fingerprint , string authenticationFlow , string funding , string avsResultRaw , string cvvResultRaw , string bin , string issuerName , string issuingCountry , string lastFour , UserName cardholderName , string cvv , string dateOfBirth , string businessNo , string cardPasswordDigest , string cpf , string payerEmail , string networkTransactionId , bool? is3DSAuthentication , string request3DS , string scaExemptionIndicator , string enableAuthenticationUpgrade , MpiData mpiData)
        {
            this.SupportedBrands = supportedBrands;
            this.CardToken = cardToken;
            this.CardNo = cardNo;
            this.Brand = brand;
            this.SelectedCardBrand = selectedCardBrand;
            this.CardIssuer = cardIssuer;
            this.CountryIssue = countryIssue;
            this.InstUserName = instUserName;
            this.ExpiryYear = expiryYear;
            this.ExpiryMonth = expiryMonth;
            this.BillingAddress = billingAddress;
            this.Mask = mask;
            this.Last4 = last4;
            this.PaymentMethodDetailMetadata = paymentMethodDetailMetadata;
            this.MaskedCardNo = maskedCardNo;
            this.Fingerprint = fingerprint;
            this.AuthenticationFlow = authenticationFlow;
            this.Funding = funding;
            this.AvsResultRaw = avsResultRaw;
            this.CvvResultRaw = cvvResultRaw;
            this.Bin = bin;
            this.IssuerName = issuerName;
            this.IssuingCountry = issuingCountry;
            this.LastFour = lastFour;
            this.CardholderName = cardholderName;
            this.Cvv = cvv;
            this.DateOfBirth = dateOfBirth;
            this.BusinessNo = businessNo;
            this.CardPasswordDigest = cardPasswordDigest;
            this.Cpf = cpf;
            this.PayerEmail = payerEmail;
            this.NetworkTransactionId = networkTransactionId;
            this.Is3DSAuthentication = is3DSAuthentication;
            this.Request3DS = request3DS;
            this.ScaExemptionIndicator = scaExemptionIndicator;
            this.EnableAuthenticationUpgrade = enableAuthenticationUpgrade;
            this.MpiData = mpiData;
        }

            public string SupportedBrands { get; set; }
            public string CardToken { get; set; }
            public string CardNo { get; set; }
            public CardBrand Brand { get; set; }
            public CardBrand SelectedCardBrand { get; set; }
            public string CardIssuer { get; set; }
            public string CountryIssue { get; set; }
            public UserName InstUserName { get; set; }
            public string ExpiryYear { get; set; }
            public string ExpiryMonth { get; set; }
            public Address BillingAddress { get; set; }
            public string Mask { get; set; }
            public string Last4 { get; set; }
            public string PaymentMethodDetailMetadata { get; set; }
            public string MaskedCardNo { get; set; }
            public string Fingerprint { get; set; }
            public string AuthenticationFlow { get; set; }
            public string Funding { get; set; }
            public string AvsResultRaw { get; set; }
            public string CvvResultRaw { get; set; }
            public string Bin { get; set; }
            public string IssuerName { get; set; }
            public string IssuingCountry { get; set; }
            public string LastFour { get; set; }
            public UserName CardholderName { get; set; }
            public string Cvv { get; set; }
            public string DateOfBirth { get; set; }
            public string BusinessNo { get; set; }
            public string CardPasswordDigest { get; set; }
            public string Cpf { get; set; }
            public string PayerEmail { get; set; }
            public string NetworkTransactionId { get; set; }
            public bool? Is3DSAuthentication { get; set; }
            public string Request3DS { get; set; }
            public string ScaExemptionIndicator { get; set; }
            public string EnableAuthenticationUpgrade { get; set; }
            public MpiData MpiData { get; set; }

        

    }

}
