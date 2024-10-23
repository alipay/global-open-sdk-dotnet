using com.alipay.ams.api.entities;

namespace com.alipay.ams.api.entities;

public class CardPaymentMethodDetail
{
    public string CardToken  { get; set; }
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
}