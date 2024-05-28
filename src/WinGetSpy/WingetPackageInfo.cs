using System;

namespace WinGetSpy
{
    /// <summary>
    /// Represents the information about the WinGet package.
    /// </summary>
    public sealed class WinGetPackageInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinGetPackageInfo"/> class.
        /// </summary>
        /// <param name="packageIdentifier">
        /// The identifier of the package.
        /// </param>
        /// <param name="packageVersion">
        /// The version of the package.
        /// </param>
        /// <param name="installerType">
        /// The type of the installer.
        /// </param>
        /// <param name="x86InstallerUrl">
        /// The URL of the x86 installer.
        /// </param>
        /// <param name="x64InstallerUrl">
        /// The URL of the x64 installer.
        /// </param>
        /// <param name="armInstallerUrl">
        /// The URL of the ARM installer.
        /// </param>
        /// <param name="arm64InstallerUrl">
        /// The URL of the ARM64 installer.
        /// </param>
        public WinGetPackageInfo(
            string packageIdentifier = default,
            string packageVersion = default,
            string installerType = default,
            Uri x86InstallerUrl = default,
            Uri x64InstallerUrl = default,
            Uri armInstallerUrl = default,
            Uri arm64InstallerUrl = default)
        {
            PackageIdentifier = packageIdentifier;
            PackageVersion = packageVersion;
            InstallerType = installerType;
            X86InstallerUrl = x86InstallerUrl;
            X64InstallerUrl = x64InstallerUrl;
            ArmInstallerUrl = armInstallerUrl;
            Arm64InstallerUrl = arm64InstallerUrl;
        }

        /// <summary>
        /// Gets the identifier of the package.
        /// </summary>
        public string PackageIdentifier { get; }

        /// <summary>
        /// Gets the version of the package.
        /// </summary>
        public string PackageVersion { get; }

        /// <summary>
        /// Gets the type of the installer.
        /// </summary>
        public string InstallerType { get; }

        /// <summary>
        /// Gets the URL of the x86 installer.
        /// </summary>
        public Uri X86InstallerUrl { get; }

        /// <summary>
        /// Gets the URL of the x64 installer.
        /// </summary>
        public Uri X64InstallerUrl { get; }

        /// <summary>
        /// Gets the URL of the ARM installer.
        /// </summary>
        public Uri ArmInstallerUrl { get; }

        /// <summary>
        /// Gets the URL of the ARM64 installer.
        /// </summary>
        public Uri Arm64InstallerUrl { get; }
    }
}
