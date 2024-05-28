namespace WinGetSpy.Test
{
    public class WinGetSpyTest
    {
        [Fact]
        public async Task Test_Basic()
        {
            // Arrange, Act
            var list = await WinGetSpy.LoadCatalogAsync();

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
            var list = await WinGetSpy.LoadCatalogAsync();

            // Act
            var searchResult = list.SearchWinGetPackage(searchKeyword, matchFirstItemOnly);

            // Assert
            Assert.NotNull(searchResult);
            Assert.NotEmpty(searchResult);
            Assert.Equal(1, searchResult?.Count());
        }
    }
}