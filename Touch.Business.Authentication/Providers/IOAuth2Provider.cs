using Touch.Domain;

namespace Touch.Providers
{
    /// <summary>
    /// OAuth2 provider.
    /// </summary>
    public interface IOAuth2Provider
    {
        /// <summary>
        /// Currently authenticated OAuth2 user.
        /// </summary>
        OAuth2User CurrentUser { get; set; }
    }
}
