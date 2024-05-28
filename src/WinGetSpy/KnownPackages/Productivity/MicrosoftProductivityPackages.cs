using System.Collections.Generic;

namespace WinGetSpy.KnownPackages.Productivity.Microsoft
{
    /// <summary>
    /// Well-known Microsoft Office packages.
    /// </summary>
    public static class MicrosoftProductivityPackages
    {
        /// <summary>
        /// Gets the latest Microsoft Bing Wallpaper package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftBingWallpaper(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.BingWallpaper");

        /// <summary>
        /// Gets the latest Microsoft Edge package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosotEdge(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.Edge");

        /// <summary>
        /// Gets the latest Microsoft Hwp Converter package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftHwpConverter(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.HwpConverter");

        /// <summary>
        /// Gets the latest Microsoft Mouse and Keyboard Center package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftMouseAndKeyboardCenter(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.MouseandKeyboardCenter");

        /// <summary>
        /// Gets the latest Microsoft Office package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftOffice(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.Office");

        /// <summary>
        /// Gets the latest Microsoft OneDrive package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftOneDrive(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.OneDrive");

        /// <summary>
        /// Gets the latest Microsoft Power Automate Desktop package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftPowerAutomateDesktop(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.PowerAutomateDesktop");

        /// <summary>
        /// Gets the latest Microsoft Power BI package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftPowerBI(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.PowerBI");

        /// <summary>
        /// Gets the latest Microsoft Skype package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftSkype(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.Skype");

        /// <summary>
        /// Gets the latest Microsoft Support and Recovery Assistant package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftSupportAndRecoveryAssistant(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SupportAndRecoveryAssistant");

        /// <summary>
        /// Gets the latest Microsoft Teams package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftTeams(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.Teams");

        /// <summary>
        /// Gets the latest Microsoft Visio Viewer package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisioViewer(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisioViewer");

        /// <summary>
        /// Gets the latest Microsoft Windows Journal package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftWindowsJournal(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsJournal");
    }
}
