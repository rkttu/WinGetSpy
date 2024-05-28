using System.Runtime.InteropServices;
using WinGetSpy.KnownPackages.DevTools.Python;

namespace WinGetSpy.Test
{
    public class WinGetSpyTest
    {
        [Fact]
        public async Task Test_Basic()
        {
            // Arrange, Act
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            // Assert
            Assert.NotNull(list);
            Assert.NotEmpty(list);
            Assert.True(1 < list?.Count());
        }

        [Fact]
        public async Task Test_Search()
        {
            // Arrange
            var searchKeyword = "Microsoft.DotNet.SDK.8";
            var matchFirstItemOnly = true;
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            // Act
            var searchResult = list.SearchWinGetPackage(searchKeyword, matchFirstItemOnly);

            // Assert
            Assert.NotNull(searchResult);
            Assert.NotEmpty(searchResult);
            Assert.Equal(1, searchResult?.Count());
        }

        [Fact]
        public async Task Test_MatchArm64InstallerUrl_ConsiderCompat()
        {
            var considerCompatibility = true;
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            var arm64BestSearchResult = list
                .Where(x => x.Arm64InstallerUrl == null && x.ArmInstallerUrl == null && x.X64InstallerUrl == null && x.X86InstallerUrl != null)
                .OrderBy(x => Guid.NewGuid())
                .First();

            // GetBestInstallerUrl should return x86 installer URL when consider compatibility is true.
            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.Arm64, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.Arm, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X64, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X86, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));
        }

        [Fact]
        public async Task Test_MatchArmInstallerUrl_ConsiderCompat()
        {
            var considerCompatibility = true;
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            var arm64BestSearchResult = list
                .Where(x => x.ArmInstallerUrl == null && x.X86InstallerUrl != null)
                .OrderBy(x => Guid.NewGuid())
                .First();

            // GetBestInstallerUrl should return x86 installer URL when consider compatibility is true.
            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.Arm, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X86, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));
        }

        [Fact]
        public async Task Test_MatchX64InstallerUrl_ConsiderCompat()
        {
            var considerCompatibility = true;
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            var arm64BestSearchResult = list
                .Where(x => x.X64InstallerUrl == null && x.X86InstallerUrl != null)
                .OrderBy(x => Guid.NewGuid())
                .First();

            // GetBestInstallerUrl should return x86 installer URL when consider compatibility is true.
            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X64, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X86, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));
        }

        [Fact]
        public async Task Test_MatchArm64InstallerUrl_DoNotConsiderCompat()
        {
            var considerCompatibility = false;
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            var arm64BestSearchResult = list
                .Where(x => x.Arm64InstallerUrl != null && x.ArmInstallerUrl != null && x.X64InstallerUrl != null && x.X86InstallerUrl != null)
                .OrderBy(x => Guid.NewGuid())
                .First();

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.Arm64, considerCompatibility),
                arm64BestSearchResult.Arm64InstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.Arm, considerCompatibility),
                arm64BestSearchResult.ArmInstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X64, considerCompatibility),
                arm64BestSearchResult.X64InstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X86, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));
        }

        [Fact]
        public async Task Test_MatchArmInstallerUrl_DoNotConsiderCompat()
        {
            var considerCompatibility = false;
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            var arm64BestSearchResult = list
                .Where(x => x.ArmInstallerUrl != null && x.X86InstallerUrl != null)
                .OrderBy(x => Guid.NewGuid())
                .First();

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.Arm, considerCompatibility),
                arm64BestSearchResult.ArmInstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X86, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));
        }

        [Fact]
        public async Task Test_MatchX64InstallerUrl_DoNotConsiderCompat()
        {
            var considerCompatibility = false;
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            var arm64BestSearchResult = list
                .Where(x => x.X64InstallerUrl != null && x.X86InstallerUrl != null)
                .OrderBy(x => Guid.NewGuid())
                .First();

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X64, considerCompatibility),
                arm64BestSearchResult.X64InstallerUrl));

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X86, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));
        }

        [Fact]
        public async Task Test_MatchX86InstallerUrl()
        {
            var considerCompatibility = true;
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            var arm64BestSearchResult = list
                .Where(x => x.X86InstallerUrl != null)
                .OrderBy(x => Guid.NewGuid())
                .First();

            Assert.True(object.Equals(
                arm64BestSearchResult.GetBestInstallerUrlFor(Architecture.X86, considerCompatibility),
                arm64BestSearchResult.X86InstallerUrl));
        }

        [Fact]
        public async Task Test_KnownPackage()
        {
            // Arrange
            var list = await WinGetCatalogManager.LoadCatalogAsync();

            // Act
            var result = list.GetJetBrainsPyCharmProfessionalEAP();

            // Assert
            Assert.NotNull(result);
        }
    }
}