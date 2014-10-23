using Touch.Domain;

namespace Touch.Providers
{
    /// <summary>
    /// OAuth2 manager.
    /// </summary>
    public interface IOAuth2Manager
    {
        /// <summary>
        /// Validate user credentials.
        /// </summary>
        bool ValidateUserCredentials(string userName, string password, string clientId);

        /// <summary>
        /// Get the user by username and client ID.
        /// </summary>
        /// <returns>User object ir <c>null</c> if user not found.</returns>
        OAuth2User GetUser(string userName, string clientId);
    }
}
