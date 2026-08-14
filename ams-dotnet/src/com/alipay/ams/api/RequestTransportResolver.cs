using System;

namespace com.alipay.ams.api
{
    internal static class RequestTransportResolver
    {
        private static readonly (string Method, string Path)[] SessionHttp2Routes =
        {
            ("POST", "/ams/api/v1/meter/uploadEvent")
        };

        internal static bool RequiresSessionHttp2(string method, string path)
        {
            foreach (var route in SessionHttp2Routes)
            {
                if (string.Equals(method, route.Method, StringComparison.OrdinalIgnoreCase)
                    && string.Equals(path, route.Path, StringComparison.Ordinal))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
