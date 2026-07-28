using System;

namespace com.alipay.ams.api
{
    internal static class SandboxPathResolver
    {
        private static readonly string[] ProductionPathPrefixes =
        {
            "/ams/api/v1/billing/",
            "/ams/api/v1/meter/"
        };

        internal static bool ShouldUseProductionPathInSandbox(string path)
        {
            foreach (var prefix in ProductionPathPrefixes)
            {
                if (path.StartsWith(prefix, StringComparison.Ordinal))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
