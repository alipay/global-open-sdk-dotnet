

namespace com.alipay.ams.api.entities
{
    public class ChallengeActionForm
    {

        public ChallengeType ChallengeType { get; set; }


        public string ChallengeRenderValue { get; set; }


        public ChallengeTriggerSourceType ChallengeTriggerSourceType { get; set; }


        public string ExtendInfo { get; set; }
    }
}
