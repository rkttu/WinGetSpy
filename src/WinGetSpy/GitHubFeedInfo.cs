using System;

namespace WinGetSpy
{
    /// <summary>
    /// Represents the information about the GitHub feed.
    /// </summary>
    public sealed class GitHubFeedInfo
    {
        private Uri _baseUri = new Uri("https://github.com", UriKind.Absolute);
        private string _repoOwner = "microsoft";
        private string _repoName = "winget-pkgs";
        private string _branchName = "master";

        /// <summary>
        /// Gets or sets the base URI of the GitHub.com.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the owner of the repository.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the name of the repository.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the name of the branch.
        /// </summary>
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

        /// <summary>
        /// Gets the URI of the repository ZIP file.
        /// </summary>
        public Uri ZipArchiveUri
            => new Uri(_baseUri, new Uri($"/{_repoOwner}/{_repoName}/archive/refs/heads/{_branchName}.zip", UriKind.Relative));

        /// <summary>
        /// Gets the cache identifier for local caching.
        /// </summary>
        public string CacheIdentifier
            => string.Join("_", "wingetspycache", _baseUri.Host, _baseUri.Port, _repoOwner, _repoName, _branchName);
    }
}
