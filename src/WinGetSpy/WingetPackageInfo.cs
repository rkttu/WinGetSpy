using System;

namespace WinGetSpy
{
    public sealed class WingetPackageInfo
    {
        public WingetPackageInfo(
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

        public string PackageIdentifier { get; }
        public string PackageVersion { get; }
        public string InstallerType { get; }
        public Uri X86InstallerUrl { get; }
        public Uri X64InstallerUrl { get; }
        public Uri ArmInstallerUrl { get; }
        public Uri Arm64InstallerUrl { get; }
    }
}
