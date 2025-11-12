namespace com.alipay.ams.api.entities
{

    public class Declaration
    {

        public Declaration() { }

        public Declaration( DeclarationBizSceneType declarationBizScene , string declarationBeneficiaryId)
        {
            this.DeclarationBizScene = declarationBizScene;
            this.DeclarationBeneficiaryId = declarationBeneficiaryId;
        }

        public DeclarationBizSceneType DeclarationBizScene { get; set; }
        public string DeclarationBeneficiaryId { get; set; }



    }

}