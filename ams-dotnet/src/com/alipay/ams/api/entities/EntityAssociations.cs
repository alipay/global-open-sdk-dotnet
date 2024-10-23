namespace com.alipay.ams.api.entities;

public class EntityAssociations
{
    public AssociationType AssociationType { get; set; }
    public LegalEntityType LegalEntityType { get; set; }
    public Company Company { get; set; }
    public Individual Individual { get; set; }
    public string ShareholdingRatio { get; set; }
}