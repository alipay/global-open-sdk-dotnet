using System;

namespace com.alipay.ams.api
{
    internal static class SandboxPathResolver
    {
        // Billing and Meter APIs now support sandbox. Keep the filter logic for future use.
        private static readonly string[] ProductionPathPrefixes =
        {
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
