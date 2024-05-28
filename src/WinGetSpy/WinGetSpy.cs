using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Linq;
using YamlDotNet.RepresentationModel;
using Yaml2JsonNode;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace WinGetSpy
{
    public static class WinGetSpy
    {
        public static readonly string DefaultUserAgent = "WinGetSpy/1.0";

        public static async Task<IReadOnlyList<WingetPackageInfo>> LoadCatalogAsync(bool forceCacheCompile = false, CancellationToken cancellationToken = default)
        {
            var appDirectoryPath = GetCacheDirectoryPath();

            if (!Directory.Exists(appDirectoryPath))
                Directory.CreateDirectory(appDirectoryPath);

            var list = await TryLoadLocalWinGetPackagesCacheAsync(
                appDirectoryPath: appDirectoryPath,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            if (forceCacheCompile || list == default)
            {
                await CompileJsonDataFromWinGetPackageAsync(
                    appDirectoryPath: appDirectoryPath,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                list = await TryLoadLocalWinGetPackagesCacheAsync(
                    appDirectoryPath: appDirectoryPath,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            return list;
        }

        public static string GetCacheDirectoryPath()
            => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WinGetSpy");

        public static async Task<IReadOnlyList<WingetPackageInfo>> TryLoadLocalWinGetPackagesCacheAsync(string appDirectoryPath = default, GitHubFeedInfo feedInfo = default, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(appDirectoryPath))
                appDirectoryPath = GetCacheDirectoryPath();

            if (!Directory.Exists(appDirectoryPath))
                return default;

            if (feedInfo == default)
                feedInfo = new GitHubFeedInfo();

            var compiledJsonDataPath = Path.Combine(appDirectoryPath, $"{feedInfo.CacheIdentifier}.json");
            var fileInfo = new FileInfo(compiledJsonDataPath);

            if (!fileInfo.Exists)
                return default;

            try
            {
                using (var fileStream = fileInfo.OpenRead())
                {
                    return await JsonSerializer.DeserializeAsync<IReadOnlyList<WingetPackageInfo>>(fileStream, cancellationToken: cancellationToken).ConfigureAwait(false);
                }
            }
            catch { return default; }
        }

        public static async Task CompileJsonDataFromWinGetPackageAsync(
            string appDirectoryPath = default, GitHubFeedInfo feedInfo = default, string customUserAgent = default,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(appDirectoryPath))
                appDirectoryPath = GetCacheDirectoryPath();

            if (!Directory.Exists(appDirectoryPath))
                Directory.CreateDirectory(appDirectoryPath);

            if (feedInfo == default)
                feedInfo = new GitHubFeedInfo();

            if (string.IsNullOrWhiteSpace(customUserAgent))
                customUserAgent = DefaultUserAgent;

            if (string.IsNullOrWhiteSpace(customUserAgent))
                customUserAgent = DefaultUserAgent;

            var zipFilePath = Path.Combine(
                Path.GetTempPath(),
                $"{Guid.NewGuid().ToString("n")}.zip");

            var list = default(IReadOnlyList<WingetPackageInfo>);
            var wingetPkgsZipFileUrl = feedInfo.ZipArchiveUri;

            using (var httpClient = new HttpClient())
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, wingetPkgsZipFileUrl))
            {
                httpRequest.Headers.TryAddWithoutValidation("Accept", "application/zip");
                httpRequest.Headers.TryAddWithoutValidation("User-Agent", customUserAgent);

                if (Directory.Exists(zipFilePath))
                    Directory.Delete(zipFilePath);

                if (File.Exists(zipFilePath))
                    File.Delete(zipFilePath);

                using (var httpResponse = await httpClient.SendAsync(httpRequest, HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false))
                using (var contentStream = await httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var localStream = File.Open(zipFilePath, FileMode.Create, FileAccess.Write))
                {
                    await contentStream.CopyToAsync(localStream).ConfigureAwait(false);
                }

                list = EnumerateWinGetPackages(zipFilePath)
                    .OrderBy(x => x.PackageIdentifier)
                    .ThenByDescending(x => x.PackageVersion)
                    .ToList();
            }

            if (File.Exists(zipFilePath))
                File.Delete(zipFilePath);

            var jsonDataPath = Path.Combine(appDirectoryPath, $"{feedInfo.CacheIdentifier}.json");

            using (var jsonFile = File.OpenWrite(jsonDataPath))
            {
                await JsonSerializer.SerializeAsync(jsonFile, list, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        static IEnumerable<WingetPackageInfo> EnumerateWinGetPackages(string zipFilePath)
        {
            if (!File.Exists(zipFilePath))
                throw new FileNotFoundException($"File '{zipFilePath}' does not exists.");

            using (var zipFile = ZipFile.OpenRead(zipFilePath))
            {
                var installerYamlFiles = zipFile.Entries.Where(x => x.FullName.StartsWith("winget-pkgs-master/manifests/") && x.FullName.EndsWith(".installer.yaml"));
                var utf8Encoding = new UTF8Encoding(false);

                foreach (var eachInstallerYamlFile in installerYamlFiles)
                {
                    using (var yamlContentStream = eachInstallerYamlFile.Open())
                    {
                        var reader = new StreamReader(yamlContentStream, utf8Encoding, true);

                        var yamlStream = new YamlStream();
                        yamlStream.Load(reader);
                        var content = YamlConverter.ToJsonNode(yamlStream).FirstOrDefault();

                        var packageIdentifier = content?["PackageIdentifier"]?.GetValue<string>();
                        var packageVersion = content?["PackageVersion"]?.AsValue().ToString();

                        if (string.IsNullOrWhiteSpace(packageIdentifier) ||
                            string.IsNullOrWhiteSpace(packageVersion))
                            continue;

                        var installerType = content?["InstallerType"]?.GetValue<string>();
                        var x86InstallerUrl = default(Uri);
                        var x64InstallerUrl = default(Uri);
                        var armInstallerUrl = default(Uri);
                        var arm64InstallerUrl = default(Uri);

                        foreach (var eachInstallerNode in content?["Installers"]?.AsArray() ?? new JsonArray())
                        {
                            if (eachInstallerNode == default)
                                continue;

                            var arch = eachInstallerNode["Architecture"]?.GetValue<string>();
                            var rawUrl = eachInstallerNode["InstallerUrl"]?.GetValue<string>();

                            if (string.IsNullOrWhiteSpace(arch) || string.IsNullOrWhiteSpace(rawUrl))
                                continue;

                            switch (arch)
                            {
                                case "x86":
                                    if (!Uri.TryCreate(rawUrl, UriKind.Absolute, out x86InstallerUrl))
                                        continue;
                                    break;
                                case "x64":
                                    if (!Uri.TryCreate(rawUrl, UriKind.Absolute, out x64InstallerUrl))
                                        continue;
                                    break;
                                case "arm":
                                    if (!Uri.TryCreate(rawUrl, UriKind.Absolute, out armInstallerUrl))
                                        continue;
                                    break;
                                case "arm64":
                                    if (!Uri.TryCreate(rawUrl, UriKind.Absolute, out arm64InstallerUrl))
                                        continue;
                                    break;
                                case "neutral":
                                    if (!Uri.TryCreate(rawUrl, UriKind.Absolute, out Uri parsedInstallerUrl))
                                        continue;
                                    x86InstallerUrl = x64InstallerUrl = armInstallerUrl = arm64InstallerUrl = parsedInstallerUrl;
                                    break;
                                default:
                                    continue;
                            }
                        }

                        yield return new WingetPackageInfo(
                            packageIdentifier,
                            packageVersion,
                            installerType,
                            x86InstallerUrl,
                            x64InstallerUrl,
                            armInstallerUrl,
                            arm64InstallerUrl);
                    }
                }
            }
        }
    }
}
