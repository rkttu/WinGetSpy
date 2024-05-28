using System.Collections.Generic;
using System;
using System.Linq;

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
    }
}
