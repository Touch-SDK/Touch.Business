using System;
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
        /// Create a new user for the given client.
        /// </summary>
        /// <param name="clientId">Client ID.</param>
        /// <returns>New user object.</returns>
        /// <exception cref="NotSupportedException">User creation is not supported by the client.</exception>
        OAuth2User CreateUser(string clientId);

        /// <summary>
        /// Get the user by username and client ID.
        /// </summary>
        /// <returns>User object or <c>null</c> if user not found.</returns>
        OAuth2User GetUser(string userName, string clientId);

        /// <summary>
        /// Get client by ID.
        /// </summary>
        /// <param name="clientId">Client ID.</param>
        /// <returns>Client object or <c>null</c> if client not found.</returns>
        OAuth2Client GetClient(string clientId);
    }
}
