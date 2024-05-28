# WinGetSpy

[![NuGet Version](https://img.shields.io/nuget/v/WinGetSpy)](https://www.nuget.org/packages/WinGetSpy/) [![GitHub Sponsors](https://img.shields.io/github/sponsors/rkttu)](https://github.com/sponsors/rkttu/)

A library to help you programmatically explore WinGet package feeds.

## Minimum Requirements

- Requires a platform with .NET Standard 2.0 or later, and Windows Vista+, Windows Server 2008+
  - This library does not support ADM files.
  - Supported .NET Version: .NET Core 2.0+, .NET 5+, .NET Framework 4.6.1+, Mono 5.4+, UWP 10.0.16299+, Unity 2018.1+

## Introduction

WinGetSpy is a library that helps you programmatically explore WinGet package feeds. WinGetSpy first caches the package feed data and then provides a simple API to search for packages and installer URLs.

WinGetSpy provides the following features:

- **Cache package feed data**: WinGetSpy caches the package feed data from the official WinGet GitHub repository.
- **Search for a package**: WinGetSpy provides a simple API to search for packages and installer URLs.
- **Get package information**: WinGetSpy provides a simple API to get package information.
- **Get installer URLs and type**: WinGetSpy provides a simple API to get the installer URLs and type.
- **Get package version**: WinGetSpy provides a simple API to get the package version.

## How to use

### Cache package cache and search for a package

```csharp
var searchKeyword = "Microsoft.DotNet.SDK.8";
var matchFirstItemOnly = true;
var forceCacheCompile = false;

using var cancellationTokenSource = new CancellationTokenSource();
var cancellationToken = cancellationTokenSource.Token;

await Console.Out.WriteLineAsync("Checking local winget-pkgs cache...".AsMemory(), cancellationToken).ConfigureAwait(false);
var list = await WinGetSpy.TryLoadLocalWinGetPackagesCacheAsync(cancellationToken: cancellationToken).ConfigureAwait(false);

if (forceCacheCompile || list == default)
{
	await Console.Out.WriteLineAsync("Compiling winget-pkgs cache from GitHub ZIP ball...".AsMemory(), cancellationToken).ConfigureAwait(false);
	await WinGetSpy.CompileJsonDataFromWinGetPackageAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
}

await Console.Out.WriteLineAsync("Loading pre-compiled winget-pkgs cache...".AsMemory(), cancellationToken).ConfigureAwait(false);
list = await WinGetSpy.TryLoadLocalWinGetPackagesCacheAsync(cancellationToken: cancellationToken).ConfigureAwait(false);

await Console.Out.WriteLineAsync($"Total {list.Count()} packages found.".AsMemory(), cancellationToken).ConfigureAwait(false);
list.SearchWinGetPackage(searchKeyword, matchFirstItemOnly).Dump();
```

## License

This library follows Apache-2.0 license. See [LICENSE](./LICENSE) file for more information.
