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
        /// Get user for the given ticket.
        /// </summary>
        /// <param name="token">Ticket token.</param>
        /// <param name="clientId">Client ID.</param>
        /// <returns>User object or <c>null</c> if user not found.</returns>
        OAuth2User GetUserByTicket(string token, string clientId);

        /// <summary>
        /// Get the user by username and client ID.
        /// </summary>
        /// <returns>User object or <c>null</c> if user not found.</returns>
        OAuth2User GetUserByUsername(string userName, string clientId);

        /// <summary>
        /// Get client by ID.
        /// </summary>
        /// <param name="clientId">Client ID.</param>
        /// <returns>Client object or <c>null</c> if client not found.</returns>
        OAuth2Client GetClient(string clientId);

        /// <summary>
        /// Consume user ticket.
        /// </summary>
        /// <param name="token">Ticket token.</param>
        /// <param name="clientId">Client ID.</param>
        /// <exception cref="IndexOutOfRangeException">Missing ticket of client.</exception>
        void ConsumeUserTicket(string token, string clientId);
    }
}
