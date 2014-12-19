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
        /// Grant API access for the given user with client ID.
        /// </summary>
        /// <param name="userName">Username.</param>
        /// <param name="clientId">Client ID.</param>
        /// <exception cref="NotSupportedException">Username access grant is not supported by the client.</exception>
        OAuth2Access GrantAccess(string userName, string clientId);

        /// <summary>
        /// Get API access object for the given ID.
        /// </summary>
        /// <param name="accessId">Access ID.</param>
        /// <param name="clientId">Client ID.</param>
        /// <returns>Access object or <c>null</c> if no valid access found.</returns>
        OAuth2Access GetAccess(string accessId, string clientId);

        /// <summary>
        /// Get client by ID.
        /// </summary>
        /// <param name="clientId">Client ID.</param>
        /// <returns>Client object or <c>null</c> if client not found.</returns>
        OAuth2Client GetClient(string clientId);

        /// <summary>
        /// Get the lifespan for given API access.
        /// </summary>
        /// <returns><c>TimeSpan</c> value, <c>TimeSpan.MaxValue</c> when access has infinite lifespan.</returns>
        TimeSpan GetAccessLifeSpan(OAuth2Access access);
    }
}
