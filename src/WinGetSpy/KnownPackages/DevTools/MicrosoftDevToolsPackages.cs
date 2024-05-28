using System.Collections.Generic;

namespace WinGetSpy.KnownPackages.DevTools.Microsoft
{
    /// <summary>
    /// Well-known Microsoft Developer Tools packages.
    /// </summary>
    public static class MicrosoftDevToolsPackages
    {
        /// <summary>
        /// Gets the latest Microsoft App Installer File Builder package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftAppInstallerFileBuilder(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.AppInstallerFileBuilder");

        /// <summary>
        /// Gets the latest Microsoft Build Tools 2015 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftBuildTools2015(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.BuildTools2015");

        /// <summary>
        /// Gets the latest Microsoft Dev Home package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftDevHome(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DevHome");

        /// <summary>
        /// Gets the latest Microsoft Dev Proxy package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftDevProxy(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DevProxy");

        /// <summary>
        /// Gets the latest Microsoft Dev Tunnel package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftDevTunnel(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.devtunnel");

        /// <summary>
        /// Gets the latest ASP.NET Core 5 package.
        /// </summary>
        public static WinGetPackageInfo GetAspNetCore5(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.AspNetCore.5");

        /// <summary>
        /// Gets the latest ASP.NET Core 6 package.
        /// </summary>
        public static WinGetPackageInfo GetAspNetCore6(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.AspNetCore.6");

        /// <summary>
        /// Gets the latest ASP.NET Core 7 package.
        /// </summary>
        public static WinGetPackageInfo GetAspNetCore7(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.AspNetCore.7");

        /// <summary>
        /// Gets the latest ASP.NET Core 8 package.
        /// </summary>
        public static WinGetPackageInfo GetAspNetCore8(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.AspNetCore.8");

        /// <summary>
        /// Gets the latest ASP.NET Core Preview package.
        /// </summary>
        public static WinGetPackageInfo GetAspNetCorePreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.AspNetCore.Preview");

        /// <summary>
        /// Gets the latest .NET Desktop Runtime 5 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetDesktopRuntime5(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.DesktopRuntime.5");

        /// <summary>
        /// Gets the latest .NET Desktop Runtime 6 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetDesktopRuntime6(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.DesktopRuntime.6");

        /// <summary>
        /// Gets the latest .NET Desktop Runtime 7 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetDesktopRuntime7(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.DesktopRuntime.7");

        /// <summary>
        /// Gets the latest .NET Desktop Runtime 8 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetDesktopRuntime8(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.DesktopRuntime.8");

        /// <summary>
        /// Gets the latest .NET Desktop Runtime Preview package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetDesktopRuntimePreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.DesktopRuntime.Preview");

        /// <summary>
        /// Gets the latest .NET Hosting Bundle 5 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetHostingBundle5(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.HostingBundle.5");

        /// <summary>
        /// Gets the latest .NET Hosting Bundle 6 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetHostingBundle6(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.HostingBundle.6");

        /// <summary>
        /// Gets the latest .NET Hosting Bundle 7 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetHostingBundle7(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.HostingBundle.7");

        /// <summary>
        /// Gets the latest .NET Hosting Bundle 8 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetHostingBundle8(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.HostingBundle.8");

        /// <summary>
        /// Gets the latest .NET Hosting Bundle Preview package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetHostingBundlePreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.HostingBundle.Preview");

        /// <summary>
        /// Gets the latest .NET Runtime 5 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetRuntime5(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.Runtime.5");

        /// <summary>
        /// Gets the latest .NET Runtime 6 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetRuntime6(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.Runtime.6");

        /// <summary>
        /// Gets the latest .NET Runtime 7 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetRuntime7(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.Runtime.7");

        /// <summary>
        /// Gets the latest .NET Runtime 8 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetRuntime8(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.Runtime.8");

        /// <summary>
        /// Gets the latest .NET Runtime Preview package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetRuntimePreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.Runtime.Preview");

        /// <summary>
        /// Gets the latest .NET SDK 5 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetSDK5(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.SDK.5");

        /// <summary>
        /// Gets the latest .NET SDK 6 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetSDK6(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.SDK.6");

        /// <summary>
        /// Gets the latest .NET SDK 7 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetSDK7(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.SDK.7");

        /// <summary>
        /// Gets the latest .NET SDK 8 package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetSDK8(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.SDK.8");

        /// <summary>
        /// Gets the latest .NET SDK Preview package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetSDKPreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.SDK.Preview");

        /// <summary>
        /// Gets the latest .NET Uninstall Tool package.
        /// </summary>
        public static WinGetPackageInfo GetDotNetUninstallTool(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.DotNet.UninstallTool");

        /// <summary>
        /// Gets the latest Microsoft Edge Driver package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftEdgeDriver(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.EdgeDriver");

        /// <summary>
        /// Gets the latest Microsoft Edge WebView2 Runtime package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftEdgeWebView2Runtime(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.EdgeWebView2Runtime");

        /// <summary>
        /// Gets the latest Microsoft GDK 2303 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftGDK2303(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.GDK.2303");

        /// <summary>
        /// Gets the latest Microsoft GDK 2306 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftGDK2306(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.GDK.2306");

        /// <summary>
        /// Gets the latest Microsoft GDK 2310 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftGDK2310(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.GDK.2310");

        /// <summary>
        /// Gets the latest Microsoft GDK 2403 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftGDK2403(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.GDK.2403");

        /// <summary>
        /// Gets the latest Microsoft Git package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftGit(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.Git");

        /// <summary>
        /// Gets the latest Microsoft Log Parser package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftLogParser(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.LogParser");

        /// <summary>
        /// Gets the latest Microsoft NuGet package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftNuGet(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.NuGet");

        /// <summary>
        /// Gets the latest Microsoft OpenJDK 11 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftOpenJDK11(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.OpenJDK.11");

        /// <summary>
        /// Gets the latest Microsoft OpenJDK 16 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftOpenJDK16(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.OpenJDK.16");

        /// <summary>
        /// Gets the latest Microsoft OpenJDK 17 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftOpenJDK17(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.OpenJDK.17");

        /// <summary>
        /// Gets the latest Microsoft OpenJDK 21 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftOpenJDK21(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.OpenJDK.21");

        /// <summary>
        /// Gets the latest Microsoft PowerShell package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftPowerShell(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.PowerShell");

        /// <summary>
        /// Gets the latest Microsoft PowerShell Preview package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftPowerShellPreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.PowerShell.Preview");

        /// <summary>
        /// Gets the latest Microsoft PowerToys package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftPowerToys(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.PowerToys");

        /// <summary>
        /// Gets the latest Microsoft Small Basic package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftSmallBasic(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SmallBasic");

        /// <summary>
        /// Gets the latest Microsoft SQLCmd package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftSqlCmd(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.Sqlcmd");

        /// <summary>
        /// Gets the latest SQL Server 2012 Native Client package.
        /// </summary>
        public static WinGetPackageInfo GetSqlServer2012NativeClient(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SQLServer.2012.NativeClient");

        /// <summary>
        /// Gets the latest SQL Server 2017 Developer package.
        /// </summary>
        public static WinGetPackageInfo GetSqlServer2017Developer(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SQLServer.2017.Developer");

        /// <summary>
        /// Gets the latest SQL Server 2017 Express package.
        /// </summary>
        public static WinGetPackageInfo GetSqlServer2017Express(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SQLServer.2017.Express");

        /// <summary>
        /// Gets the latest SQL Server 2019 Developer package.
        /// </summary>
        public static WinGetPackageInfo GetSqlServer2019Developer(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SQLServer.2019.Developer");

        /// <summary>
        /// Gets the latest SQL Server 2019 Express package.
        /// </summary>
        public static WinGetPackageInfo GetSqlServer2019Express(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SQLServer.2019.Express");

        /// <summary>
        /// Gets the latest SQL Server 2022 Developer package.
        /// </summary>
        public static WinGetPackageInfo GetSqlServer2022Developer(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SQLServer.2022.Developer");

        /// <summary>
        /// Gets the latest SQL Server 2022 Express package.
        /// </summary>
        public static WinGetPackageInfo GetSqlServer2022Express(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SQLServer.2022.Express");

        /// <summary>
        /// Gets the latest SQL Server Management Studio package.
        /// </summary>
        public static WinGetPackageInfo GetSqlServerManagementStudio(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SQLServerManagementStudio");

        /// <summary>
        /// Gets the latest Microsoft Surface Duo Android 11 Emulator package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftSurfaceDuoAndroid11Emulator(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.SurfaceDuoEmulator.Android11");

        /// <summary>
        /// Gets the latest Microsoft Time Travel Debugging package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftTimeTravelDebugging(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.TimeTravelDebugging");

        /// <summary>
        /// Gets the latest Microsoft UI Xaml 2.7 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftUIXaml27(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.UI.Xaml.2.7");

        /// <summary>
        /// Gets the latest Microsoft UI Xaml 2.8 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftUIXaml28(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.UI.Xaml.2.8");

        /// <summary>
        /// Gets the latest Microsoft VCLibs Desktop 14 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCLibsDesktop14(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCLibs.Desktop.14");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2005 x64 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2005x64(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2005.x64");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2005 x86 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2005x86(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2005.x86");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2008 x64 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2008x64(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2008.x64");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2008 x86 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2008x86(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2008.x86");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2010 x64 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2010x64(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2010.x64");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2010 x86 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2010x86(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2010.x86");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2012 x64 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2012x64(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2012.x64");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2012 x86 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2012x86(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2012.x86");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2013 x64 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2013x64(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2013.x64");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2013 x86 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2013x86(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2013.x86");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2015 and latest x64 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2015AndLatestx64(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2015+.x64");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2015 and latest x86 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2015AndLatestx86(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2015+.x86");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2019 Arm64 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2019Arm64(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2019.arm64");

        /// <summary>
        /// Gets the latest Microsoft VC Redist 2022 Arm64 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVCRedist2022Arm64(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VCRedist.2022.arm64");

        /// <summary>
        /// Gets the latest Microsoft VFS for Git package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVFSforGit(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VFSforGit");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2019 Build Tools package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2019BuildTools(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2019.BuildTools");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2019 Professional package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2019Professional(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2019.Professional");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2019 Enterprise package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2019Enterprise(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2019.Enterprise");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2022 Build Tools package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2022BuildTools(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2022.BuildTools");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2022 Community package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2022Community(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2022.Community");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2022 Community Preview package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2022CommunityPreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2022.Community.Preview");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2022 Professional package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2022Professional(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2022.Professional");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2022 Professional Preview package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2022ProfessionalPreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2022.Professional.Preview");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2022 Enterprise package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2022Enterprise(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2022.Enterprise");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio 2022 Enterprise Preview package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudio2022EnterprisePreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.2022.Enterprise.Preview");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio Config Finder package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudioConfigFinder(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.ConfigFinder");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio Locator package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudioLocator(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudio.Locator");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio Code package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudioCode(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudioCode");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio Code CLI package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudioCodeCLI(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudioCode.CLI");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio Code Insiders package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudioCodeInsiders(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudioCode.Insiders");

        /// <summary>
        /// Gets the latest Microsoft Visual Studio Code Insiders CLI package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftVisualStudioCodeInsidersCLI(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.VisualStudioCode.Insiders.CLI");

        /// <summary>
        /// Gets the latest Microsoft WebPI Command Line package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftWebPICmd(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.webpicmd");

        /// <summary>
        /// Gets the latest Microsoft WinDbg package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftWinDbg(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WinDbg");

        /// <summary>
        /// Gets the latest Windows SDK 10.0.17736 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsSDK_10_0_17736(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsSDK.10.0.17736");

        /// <summary>
        /// Gets the latest Windows SDK 10.0.18362 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsSDK_10_0_18362(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsSDK.10.0.18362");

        /// <summary>
        /// Gets the latest Windows SDK 10.0.19041 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsSDK_10_0_19041(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsSDK.10.0.19041");

        /// <summary>
        /// Gets the latest Windows SDK 10.0.20348 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsSDK_10_0_20348(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsSDK.10.0.20348");

        /// <summary>
        /// Gets the latest Windows SDK 10.0.22000 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsSDK_10_0_22000(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsSDK.10.0.22000");

        /// <summary>
        /// Gets the latest Windows SDK 10.0.22621 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsSDK_10_0_22621(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsSDK.10.0.22621");

        /// <summary>
        /// Gets the latest Windows SDK 10.0.26100 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsSDK_10_0_26100(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsSDK.10.0.26100");

        /// <summary>
        /// Gets the latest Microsoft Windows Terminal package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftWindowsTerminal(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsTerminal");

        /// <summary>
        /// Gets the latest Microsoft Windows Terminal Preview package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftWindowsTerminalPreview(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsTerminal.Preview");

        /// <summary>
        /// Gets the latest Windows WDK 10.0.19041 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsWDK_10_0_19041(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsWDK.10.0.19041");

        /// <summary>
        /// Gets the latest Windows WDK 10.0.22000 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsWDK_10_0_22000(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsWDK.10.0.22000");

        /// <summary>
        /// Gets the latest Windows WDK 10.0.22621 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsWDK_10_0_22621(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsWDK.10.0.22621");

        /// <summary>
        /// Gets the latest Windows WDK 10.0.26100 package.
        /// </summary>
        public static WinGetPackageInfo GetWindowsWDK_10_0_26100(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WindowsWDK.10.0.26100");

        /// <summary>
        /// Gets the latest Microsoft Winget Create package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftWingetCreate(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WingetCreate");

        /// <summary>
        /// Gets the latest Microsoft WSL package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftWSL(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.WSL");

        /// <summary>
        /// Gets the latest Microsoft XML Notepad package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftXMLNotepad(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.XMLNotepad");
    }
}
