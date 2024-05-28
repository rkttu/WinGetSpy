using System;

namespace WinGetSpy
{
    public sealed class GitHubFeedInfo
    {
        private Uri _baseUri = new Uri("https://github.com", UriKind.Absolute);
        private string _repoOwner = "microsoft";
        private string _repoName = "winget-pkgs";
        private string _branchName = "master";

        public Uri BaseUri
        {
            get => _baseUri;
            set
            {
                if (value == default)
                    throw new ArgumentNullException(nameof(value));

                if (!value.IsAbsoluteUri)
                    throw new ArgumentException($"{nameof(BaseUri)} should be absolute URI.", nameof(value));

                _baseUri = value;
            }
        }

        public string RepoOwner
        {
            get => _repoOwner;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"{nameof(RepoOwner)} cannot be null or whitespace string.", nameof(value));

                _repoOwner = value.Trim();
            }
        }

        public string RepoName
        {
            get => _repoName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"{nameof(RepoName)} cannot be null or whitespace string.", nameof(value));

                _repoName = value.Trim();
            }
        }

        public string BranchName
        {
            get => _branchName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"{nameof(BranchName)} cannot be null or whitespace string.", nameof(value));

                _branchName = value.Trim();
            }
        }

        public Uri ZipArchiveUri
            => new Uri(_baseUri, new Uri($"/{_repoOwner}/{_repoName}/archive/refs/heads/{_branchName}.zip", UriKind.Relative));

        public string CacheIdentifier
            => string.Join("_", "wingetspycache", _baseUri.Host, _baseUri.Port, _repoOwner, _repoName, _branchName);
    }
}
