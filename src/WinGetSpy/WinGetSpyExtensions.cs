using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace WinGetSpy
{
    /// <summary>
    /// Contains extension methods for the WinGet package information collection.
    /// </summary>
    public static class WinGetSpyExtensions
    {
        /// <summary>
        /// Searches the WinGet package information collection by the specified keyword.
        /// </summary>
        /// <param name="list">
        /// The collection of the WinGet package information.
        /// </param>
        /// <param name="searchKeyword">
        /// The keyword to search for.
        /// </param>
        /// <param name="matchFirstItemOnly">
        /// A value indicating whether to match only the first item.
        /// </param>
        /// <param name="comparisonType">
        /// The type of string comparison to use.
        /// </param>
        /// <returns>
        /// The collection of the WinGet package information that matches the specified keyword.
        /// </returns>
        public static IEnumerable<WingetPackageInfo> SearchWinGetPackage(
            this IReadOnlyList<WingetPackageInfo> list,
            string searchKeyword,
            bool matchFirstItemOnly,
            StringComparison comparisonType = default)
        {
            if (string.IsNullOrWhiteSpace(searchKeyword))
                return list;

            var queryResult = list.Where(x => x.PackageIdentifier.IndexOf(searchKeyword, comparisonType) > (-1));

            if (matchFirstItemOnly)
                return queryResult.Take(1);
            else
                return queryResult;
        }

        private static readonly Lazy<HttpClient> _httpClientFactory = new Lazy<HttpClient>(false);

        /// <summary>
        /// Gets the best installer URL for specific system.
        /// </summary>
        /// <param name="package">
        /// The WinGet package information.
        /// </param>
        /// <param name="architecture">
        /// The architecture of the system.
        /// </param>
        /// <param name="considerCompatibility">
        /// A value indicating whether to consider compatibility.
        /// </param>
        /// <returns>
        /// The best installer URL for this system.
        /// </returns>
        public static Uri GetBestInstallerUrlFor(this WingetPackageInfo package,
            Architecture? architecture = default, bool considerCompatibility = true)
        {
            architecture = architecture ?? RuntimeInformation.ProcessArchitecture;

            if (architecture == Architecture.Arm64)
            {
                if (package.Arm64InstallerUrl != null)
                    return package.Arm64InstallerUrl;
                if (!considerCompatibility)
                    return default;
                if (package.ArmInstallerUrl != null)
                    return package.ArmInstallerUrl;
                if (package.X64InstallerUrl != null)
                    return package.X64InstallerUrl;
                if (package.X86InstallerUrl != null)
                    return package.X86InstallerUrl;
                return default;
            }

            if (architecture == Architecture.Arm)
            {
                if (package.ArmInstallerUrl != null)
                    return package.ArmInstallerUrl;
                if (!considerCompatibility)
                    return default;
                if (package.X86InstallerUrl != null)
                    return package.X86InstallerUrl;
                return default;
            }

            if (architecture == Architecture.X64)
            {
                if (package.X64InstallerUrl != null)
                    return package.X64InstallerUrl;
                if (!considerCompatibility)
                    return default;
                if (package.X86InstallerUrl != null)
                    return package.X86InstallerUrl;
                return default;
            }

            if (architecture == Architecture.X86)
            {
                if (package.X86InstallerUrl != null)
                    return package.X86InstallerUrl;
                return default;
            }

            return default;
        }

        /// <summary>
        /// Gets the stream of the best installer for this system.
        /// </summary>
        /// <param name="package">
        /// The WinGet package information.
        /// </param>
        /// <param name="architecture">
        /// The architecture of the system.
        /// </param>
        /// <param name="considerCompatibility">
        /// A value indicating whether to consider compatibility.
        /// </param>
        /// <returns>
        /// The stream of the best installer for this system.
        /// </returns>
        public static Task<Stream> GetBestInstallerStreamForAsync(this WingetPackageInfo package,
            Architecture? architecture = default, bool considerCompatibility = true)
            => _httpClientFactory.Value.GetStreamAsync(GetBestInstallerUrlFor(package, architecture, considerCompatibility));

        /// <summary>
        /// Gets the stream of the x86 installer.
        /// </summary>
        /// <param name="package">
        /// The WinGet package information.
        /// </param>
        /// <returns>
        /// The stream of the x86 installer.
        /// </returns>
        public static Task<Stream> GetX86InstallerStreamAsync(this WingetPackageInfo package)
            => _httpClientFactory.Value.GetStreamAsync(package.X86InstallerUrl);

        /// <summary>
        /// Gets the stream of the x64 installer.
        /// </summary>
        /// <param name="package">
        /// The WinGet package information.
        /// </param>
        /// <returns>
        /// The stream of the x64 installer.
        /// </returns>
        public static Task<Stream> GetX64InstallerStreamAsync(this WingetPackageInfo package)
            => _httpClientFactory.Value.GetStreamAsync(package.X64InstallerUrl);

        /// <summary>
        /// Gets the stream of the ARM installer.
        /// </summary>
        /// <param name="package">
        /// The WinGet package information.
        /// </param>
        /// <returns>
        /// The stream of the ARM installer.
        /// </returns>
        public static Task<Stream> GetArmInstallerStreamAsync(this WingetPackageInfo package)
            => _httpClientFactory.Value.GetStreamAsync(package.ArmInstallerUrl);

        /// <summary>
        /// Gets the stream of the ARM64 installer.
        /// </summary>
        /// <param name="package">
        /// The WinGet package information.
        /// </param>
        /// <returns>
        /// The stream of the ARM64 installer.
        /// </returns>
        public static Task<Stream> GetArm64InstallerStreamAsync(this WingetPackageInfo package)
            => _httpClientFactory.Value.GetStreamAsync(package.Arm64InstallerUrl);
    }
}
