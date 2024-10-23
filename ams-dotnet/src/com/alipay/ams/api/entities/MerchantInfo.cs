namespace com.alipay.ams.api.entities;

public class MerchantInfo
{
    public string ReferenceMerchantId { get; set; }
    public string LoginId { get; set; }
    public LegalEntityType LegalEntityType { get; set; }
    public Company Company { get; set; }
    
    public BusinessInfo BusinessInfo { get; set; }
    public EntityAssociations[] EntityAssociations { get; set; }
}