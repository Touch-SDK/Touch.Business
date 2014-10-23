using Touch.Domain;

namespace Touch.Providers
{
    /// <summary>
    /// OAuth provider.
    /// </summary>
    public interface IOAuthProvider
    {
        /// <summary>
        /// Currently authenticated OAuth user.
        /// </summary>
        OAuthCredentials CurrentUser { get; set; }
    }
}
