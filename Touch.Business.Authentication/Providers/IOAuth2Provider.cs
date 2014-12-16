using Touch.Domain;

namespace Touch.Providers
{
    /// <summary>
    /// OAuth2 provider.
    /// </summary>
    public interface IOAuth2Provider
    {
        /// <summary>
        /// Currently active OAuth2 API access.
        /// </summary>
        OAuth2Access ActiveAccess { get; set; }
    }
}
