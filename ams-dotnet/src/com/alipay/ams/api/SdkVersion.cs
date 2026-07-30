using System;
using System.Reflection;

namespace com.alipay.ams.api
{
    internal static class SdkVersion
    {
        private const string SdkName = "global-open-sdk-dotnet";

        internal static string Version { get; } = ResolveVersion();

        internal static string UserAgent => SdkName + "/" + Version;

        private static string ResolveVersion()
        {
            var assembly = typeof(SdkVersion).Assembly;
            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            if (!string.IsNullOrWhiteSpace(attribute?.InformationalVersion))
            {
                return attribute.InformationalVersion.Split('+')[0];
            }

            var version = assembly.GetName().Version;
            if (version == null)
            {
                return "unknown";
            }

            return version.Major + "." + version.Minor + "." + Math.Max(version.Build, 0);
        }
    }
}
