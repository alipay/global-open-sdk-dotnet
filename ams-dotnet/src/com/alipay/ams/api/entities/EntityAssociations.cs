using System;
using System.Collections.Generic;
    
namespace com.alipay.ams.api.entities
{

public class EntityAssociations
    {

        public EntityAssociations() { }

        

        public EntityAssociations( AssociationType associationType , LegalEntityType legalEntityType , Company company , Individual individual , string shareholdingRatio)
        {
            this.AssociationType = associationType;
            this.LegalEntityType = legalEntityType;
            this.Company = company;
            this.Individual = individual;
            this.ShareholdingRatio = shareholdingRatio;
        }

            public AssociationType AssociationType { get; set; }
            public LegalEntityType LegalEntityType { get; set; }
            public Company Company { get; set; }
            public Individual Individual { get; set; }
            public string ShareholdingRatio { get; set; }

        

    }

}
