using System.Collections.Generic;

namespace WinGetSpy.KnownPackages.DevTools.Python
{
    /// <summary>
    /// Well-known Python Developer Tools packages.
    /// </summary>
    public static class PythonDevToolsPackages
    {
        /// <summary>
        /// Gets the latest Python Launcher package.
        /// </summary>
        public static WinGetPackageInfo GetPythonLauncher(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Launcher");

        /// <summary>
        /// Gets the latest Microsoft IronPython 2 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftIronPython2(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.IronPython.2");

        /// <summary>
        /// Gets the latest Microsoft IronPython 3 package.
        /// </summary>
        public static WinGetPackageInfo GetMicrosoftIronPython3(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Microsoft.IronPython.3");

        /// <summary>
        /// Gets the latest Python 2 package.
        /// </summary>
        public static WinGetPackageInfo GetPython2(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.2");

        /// <summary>
        /// Gets the latest Python 3.0 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_0(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.0");

        /// <summary>
        /// Gets the latest Python 3.1 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_1(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.1");

        /// <summary>
        /// Gets the latest Python 3.2 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_2(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.2");

        /// <summary>
        /// Gets the latest Python 3.3 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_3(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.3");

        /// <summary>
        /// Gets the latest Python 3.4 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_4(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.4");

        /// <summary>
        /// Gets the latest Python 3.5 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_5(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.5");

        /// <summary>
        /// Gets the latest Python 3.6 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_6(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.6");

        /// <summary>
        /// Gets the latest Python 3.7 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_7(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.7");

        /// <summary>
        /// Gets the latest Python 3.8 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_8(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.8");

        /// <summary>
        /// Gets the latest Python 3.9 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_9(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.9");

        /// <summary>
        /// Gets the latest Python 3.10 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_10(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.10");

        /// <summary>
        /// Gets the latest Python 3.11 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_11(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.11");

        /// <summary>
        /// Gets the latest Python 3.12 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_12(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.12");

        /// <summary>
        /// Gets the latest Python 3.13 package.
        /// </summary>
        public static WinGetPackageInfo GetPython3_13(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("Python.Python.3.13");

        /// <summary>
        /// Gets the latest JetBrains PyCharm Community package.
        /// </summary>
        public static WinGetPackageInfo GetJetBrainsPyCharmCommunity(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("JetBrains.PyCharm.Community");

        /// <summary>
        /// Gets the latest JetBrains PyCharm Community EAP package.
        /// </summary>
        public static WinGetPackageInfo GetJetBrainsPyCharmCommunityEAP(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("JetBrains.PyCharm.Community.EAP");

        /// <summary>
        /// Gets the latest JetBrains PyCharm Professional package.
        /// </summary>
        public static WinGetPackageInfo GetJetBrainsPyCharmProfessional(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("JetBrains.PyCharm.Professional");

        /// <summary>
        /// Gets the latest JetBrains PyCharm Professional EAP package.
        /// </summary>
        public static WinGetPackageInfo GetJetBrainsPyCharmProfessionalEAP(this IReadOnlyList<WinGetPackageInfo> list)
            => list.GetLatestPackageInfo("JetBrains.PyCharm.Professional.EAP");
    }
}
