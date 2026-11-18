using System.Text.Json;
using System.Text.Json.Nodes;
using com.alipay.ams.api.request.notify;
using com.alipay.ams.util;

static class DefenseNotificationsTests
{
    public static void Run()
    {
        var options = JsonSerializerOptionsFactory.WriteIndented;
        var s = JsonSerializer.Deserialize<AlipayDefenseStrategySuggestionNotify>("{\"disputeId\":\"d1\",\"notifyTime\":\"2026-10-22T01:02:03.123+08:00\",\"winRateLevel\":\"FUTURE\",\"evidenceList\":[{\"evidenceTag\":\"FUTURE_TAG\",\"obtained\":false,\"winRateContribution\":\"FUTURE\"},{\"evidenceTag\":\"ORDER_INFORMATION\",\"obtained\":true}],\"cardholderDisputeReason\":\"Reason\",\"defenseStrategyDescription\":\"Supply evidence\",\"futureField\":{\"ignored\":true}}", options);
        if (s.EvidenceList[0].Obtained != false || s.EvidenceList[1].Obtained != true || s.EvidenceList[1].WinRateContribution != null)
            throw new Exception("Evidence boolean/optional parsing failed");
        var d = JsonSerializer.Deserialize<AlipayDefenseDocumentNotify>("{\"disputeId\":\"d1\",\"notifyTime\":\"2026-10-22T01:02:03.123+08:00\",\"defenseFile\":{\"fileName\":\"defense.pdf\",\"fileFormat\":\"FUTURE\",\"fileMd5\":\"5d41402abc4b2a76b9719d911017c592\"},\"winRateLevel\":\"FUTURE\",\"recommendedEvidence\":{\"FUTURE_TAG\":\"提供材料\",\"ORDER_INFORMATION\":\"Order proof\"},\"suggestionsForImprovement\":\"Add proof\"}", options);
        if (!JsonNode.DeepEquals(JsonNode.Parse("{\"disputeId\":\"d1\",\"notifyTime\":\"2026-10-22T01:02:03.123+08:00\",\"winRateLevel\":\"FUTURE\",\"evidenceList\":[{\"evidenceTag\":\"FUTURE_TAG\",\"obtained\":false,\"winRateContribution\":\"FUTURE\"},{\"evidenceTag\":\"ORDER_INFORMATION\",\"obtained\":true}],\"cardholderDisputeReason\":\"Reason\",\"defenseStrategyDescription\":\"Supply evidence\"}"), JsonNode.Parse(JsonSerializer.Serialize(s, options))))
            throw new Exception("Strategy round trip failed");
        if (!JsonNode.DeepEquals(JsonNode.Parse("{\"disputeId\":\"d1\",\"notifyTime\":\"2026-10-22T01:02:03.123+08:00\",\"defenseFile\":{\"fileName\":\"defense.pdf\",\"fileFormat\":\"FUTURE\",\"fileMd5\":\"5d41402abc4b2a76b9719d911017c592\"},\"winRateLevel\":\"FUTURE\",\"recommendedEvidence\":{\"FUTURE_TAG\":\"提供材料\",\"ORDER_INFORMATION\":\"Order proof\"},\"suggestionsForImprovement\":\"Add proof\"}"), JsonNode.Parse(JsonSerializer.Serialize(d, options))))
            throw new Exception("Document round trip failed");
        foreach (var body in new[] { "{}", "{\"winRateLevel\":null,\"recommendedEvidence\":null,\"suggestionsForImprovement\":null}" }) {
            d = JsonSerializer.Deserialize<AlipayDefenseDocumentNotify>(body, options);
            if (d.WinRateLevel != null || d.RecommendedEvidence != null || d.SuggestionsForImprovement != null)
                throw new Exception("Optional fields must remain null");
        }
        s = JsonSerializer.Deserialize<AlipayDefenseStrategySuggestionNotify>("{\"evidenceList\":[{\"evidenceTag\":\"X\"}]}", options);
        if (s.EvidenceList[0].Obtained != null || s.CardholderDisputeReason != null) throw new Exception("Missing fields changed");
        Console.WriteLine("Defense notifications: PASS");
    }
}
