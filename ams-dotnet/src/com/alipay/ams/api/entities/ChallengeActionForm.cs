using System.Text.Json.Serialization;

namespace com.alipay.ams.api.entities
{
    public class ChallengeActionForm
    {
        [JsonPropertyNameAttribute("challengeType")]
        public ChallengeType ChallengeType { get; set; }

        [JsonPropertyNameAttribute("challengeRenderValue")]
        public string ChallengeRenderValue { get; set; }

        [JsonPropertyNameAttribute("challengeTriggerSourceType")]
        public ChallengeTriggerSourceType ChallengeTriggerSourceType { get; set; }

        [JsonPropertyNameAttribute("extendInfo")]
        public string ExtendInfo { get; set; }
    }
}
