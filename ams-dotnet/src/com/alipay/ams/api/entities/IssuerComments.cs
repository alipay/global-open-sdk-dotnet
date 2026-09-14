namespace com.alipay.ams.api.entities;

/// <summary>
/// Issuer and cardholder comments returned in a dispute notification.
/// </summary>
public class IssuerComments
{
    /// <summary>Cardholder-provided supplementary comments. Maximum length: 1024 characters.</summary>
    public string CardholderComments { get; set; }

    /// <summary>Issuer-provided reason for invalid authorization. Maximum length: 1024 characters.</summary>
    public string ReasonOfInvalidAuthorization { get; set; }

    /// <summary>Explanation of a previously presented credit. Maximum length: 1024 characters.</summary>
    public string ExplanationOfCreditPresented { get; set; }

    /// <summary>Issuer-provided explanation of the dispute judgment. Maximum length: 1024 characters.</summary>
    public string JudgeReason { get; set; }
}
