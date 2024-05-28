# WinGetSpy

[![NuGet Version](https://img.shields.io/nuget/v/WinGetSpy)](https://www.nuget.org/packages/WinGetSpy/) ![Build Status](https://github.com/rkttu/WinGetSpy/actions/workflows/dotnet.yml/badge.svg)
 [![GitHub Sponsors](https://img.shields.io/github/sponsors/rkttu)](https://github.com/sponsors/rkttu/)

A library to help you programmatically explore WinGet package feeds.

## Minimum Requirements

- Requires a platform with .NET Standard 2.0 or later.
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

### Cache package data and search for a package

```csharp
using WinGetSpy;

...

var searchKeyword = "Microsoft.DotNet.SDK.8";
var matchFirstItemOnly = true;
var list = await WinGetCatalogManager.LoadCatalogAsync();

var searchResult = list.SearchWinGetPackage(searchKeyword, matchFirstItemOnly);
...
```

### Get best match installer URL

```csharp
using WinGetSpy;

...

var searchKeyword = "Microsoft.DotNet.SDK.8";
var matchFirstItemOnly = true;
var list = await WinGetCatalogManager.LoadCatalogAsync();

var searchResult = list.SearchWinGetPackage(searchKeyword, matchFirstItemOnly).First();
var downloadUri = searchResult.GetBestInstallerUrlFor();
Console.WriteLine(downloadUri);

...
```

### Browse well-known packages

```csharp
using WinGetSpy;
using WinGetSpy.KnownPackages.DevTools.Python;

...

var result = list.GetJetBrainsPyCharmProfessionalEAP();
Console.WriteLine(result.GetBestInstallerUrlFor());

...
```

## License

This library follows Apache-2.0 license. See [LICENSE](./LICENSE) file for more information.
