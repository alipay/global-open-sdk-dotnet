using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace com.alipay.ams.util
{
    internal sealed class AmountRuleSet
    {
        internal readonly IReadOnlyDictionary<string, int?> Currencies;
        internal readonly IReadOnlyDictionary<string, string> Multiples;

        internal AmountRuleSet(Dictionary<string, int?> currencies, Dictionary<string, string> multiples)
        {
            Currencies = currencies;
            Multiples = multiples;
        }
    }

    internal static class AmountRuleLoader
    {
        private const string ResourceSuffix = "amount-currency-rules.json";
        private static readonly Lazy<AmountRuleSet> CachedRules =
            new Lazy<AmountRuleSet>(Load, true);

        internal static AmountRuleSet Rules => CachedRules.Value;

        private static AmountRuleSet Load()
        {
            try
            {
                Assembly assembly = typeof(AmountRuleLoader).Assembly;
                string resourceName = null;
                foreach (string name in assembly.GetManifestResourceNames())
                {
                    if (name.EndsWith(ResourceSuffix, StringComparison.Ordinal))
                    {
                        if (resourceName != null)
                            throw new InvalidOperationException("RULE_DATA_ERROR: duplicate amount rules resources");
                        resourceName = name;
                    }
                }
                if (resourceName == null)
                    throw new InvalidOperationException("RULE_DATA_ERROR: amount currency rules resource is missing");
                using Stream stream = assembly.GetManifestResourceStream(resourceName);
                if (stream == null)
                    throw new InvalidOperationException("RULE_DATA_ERROR: amount currency rules resource is missing");
                using JsonDocument document = JsonDocument.Parse(stream);
                JsonElement root = document.RootElement;
                if (root.ValueKind != JsonValueKind.Object
                    || !root.TryGetProperty("schemaVersion", out JsonElement schema)
                    || schema.GetInt32() != 1
                    || !root.TryGetProperty("currencies", out JsonElement currenciesElement)
                    || currenciesElement.ValueKind != JsonValueKind.Object
                    || !root.TryGetProperty("antomConstraints", out JsonElement constraintsElement)
                    || constraintsElement.ValueKind != JsonValueKind.Object)
                    throw new InvalidOperationException("RULE_DATA_ERROR: invalid amount currency rules structure");

                var currencies = new Dictionary<string, int?>(StringComparer.Ordinal);
                foreach (JsonProperty property in currenciesElement.EnumerateObject())
                {
                    JsonElement minor = property.Value.GetProperty("minorUnit");
                    if (minor.ValueKind == JsonValueKind.Null)
                        currencies.Add(property.Name, null);
                    else
                    {
                        int value = minor.GetInt32();
                        if (value < 0 || value > 4)
                            throw new InvalidOperationException("RULE_DATA_ERROR: invalid minor unit");
                        currencies.Add(property.Name, value);
                    }
                }

                var multiples = new Dictionary<string, string>(StringComparer.Ordinal);
                foreach (JsonProperty property in constraintsElement.EnumerateObject())
                {
                    string multiple = property.Value.GetProperty("minorValueMultiple").GetString();
                    if (!IsPowerOfTen(multiple))
                        throw new InvalidOperationException("RULE_DATA_ERROR: invalid amount constraint");
                    multiples.Add(property.Name, multiple);
                }
                return new AmountRuleSet(currencies, multiples);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException("RULE_DATA_ERROR: unable to load amount currency rules", exception);
            }
        }

        private static bool IsPowerOfTen(string value)
        {
            if (string.IsNullOrEmpty(value) || value[0] != '1') return false;
            for (int index = 1; index < value.Length; index++)
                if (value[index] != '0') return false;
            return true;
        }
    }
}
