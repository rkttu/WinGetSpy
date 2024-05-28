namespace WinGetSpy.Test
{
    public class WinGetSpyTest
    {
        private async Task<IReadOnlyList<WingetPackageInfo>?> PrepareAsync(bool forceCacheCompile, CancellationToken cancellationToken = default)
        {
            await Console.Out.WriteLineAsync("Checking local winget-pkgs cache...".AsMemory());
            var list = await WinGetSpy.TryLoadLocalWinGetPackagesCacheAsync();

            if (forceCacheCompile || list == default)
            {
                await Console.Out.WriteLineAsync("Compiling winget-pkgs cache from GitHub ZIP ball...".AsMemory());
                await WinGetSpy.CompileJsonDataFromWinGetPackageAsync();
            }

            return list;
        }

        [Fact]
        public async Task Test_Basic()
        {
            // Arrange, Act
            var list = await PrepareAsync(false);

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
            var list = await PrepareAsync(false);

            // Act
            var searchResult = list.SearchWinGetPackage(searchKeyword, matchFirstItemOnly);

            // Assert
            Assert.NotNull(searchResult);
            Assert.NotEmpty(searchResult);
            Assert.Equal(1, searchResult?.Count());
        }
    }
}