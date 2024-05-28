using System.Collections.Generic;
using System;
using System.Linq;

namespace WinGetSpy
{
    public static class WinGetSpyExtensions
    {
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
