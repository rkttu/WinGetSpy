using System;
using System.Collections.Generic;

namespace WinGetSpy.KnownPackages.Productivity.Adobe
{
    /// <summary>
    /// Well-known Adobe Productivity packages.
    /// </summary>
    public static class AdobeProductivityPackages
    {
        /// <summary>
        /// Gets the latest Adobe Acrobat Pro package.
        /// </summary>
        public static WinGetPackageInfo GetAdobeAcrobatPro(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Adobe.AcrobatPro");

        /// <summary>
        /// Gets the latest Adobe Reader 32-bit package.
        /// </summary>
        public static WinGetPackageInfo GetAdobeReader32bit(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Adobe.Reader.32-bit");

        /// <summary>
        /// Gets the latest Adobe Reader 64-bit package.
        /// </summary>
        public static WinGetPackageInfo GetAdobeReader64bit(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Adobe.Reader.64-bit");

        /// <summary>
        /// Gets the latest Adobe Reader package, preferring 32-bit if specified or if the operating system is not 64-bit.
        /// </summary>
        /// <param name="list">The list of packages to search.</param>
        /// <param name="prefer32Bit">Indicates whether to prefer the 32-bit version.</param>
        public static WinGetPackageInfo GetAdobeReader(this IReadOnlyList<WinGetPackageInfo> list, bool prefer32Bit = true)
            => prefer32Bit ? GetAdobeReader32bit(list) : Environment.Is64BitOperatingSystem ? GetAdobeReader64bit(list) : GetAdobeReader32bit(list);
    }
}
