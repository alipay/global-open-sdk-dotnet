    
namespace com.alipay.ams.api.entities
{

public class Declaration
    {

        public Declaration() { }

        public Declaration( string declarationBizScene , string declarationBeneficiaryId)
        {
            this.DeclarationBizScene = declarationBizScene;
            this.DeclarationBeneficiaryId = declarationBeneficiaryId;
        }

            public string DeclarationBizScene { get; set; }
            public string DeclarationBeneficiaryId { get; set; }

        

    }

}
