using System.Text.Json.Serialization.Metadata;
using com.alipay.ams.api.entities;

namespace com.alipay.ams.util
{
    // An unset preference inherits policy, and an empty preference object has no order.
    // Keep the existing null behavior for every unrelated SDK property.
    internal static class PaymentPreferenceJson
    {
        internal static DefaultJsonTypeInfoResolver CreateResolver()
        {
            var resolver = new DefaultJsonTypeInfoResolver();
            resolver.Modifiers.Add(typeInfo =>
            {
                string propertyName = null;
                if (typeInfo.Type == typeof(AuthorizationControl))
                    propertyName = "paymentPreference";
                else if (typeInfo.Type == typeof(PaymentPreference))
                    propertyName = "currencyOrder";
                if (propertyName == null)
                    return;
                foreach (var property in typeInfo.Properties)
                    if (property.Name == propertyName)
                        property.ShouldSerialize = (_, value) => value != null;
            });
            return resolver;
        }
    }
}
