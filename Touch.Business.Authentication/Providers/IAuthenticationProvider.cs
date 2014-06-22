using Touch.Domain;

namespace Touch.Providers
{
    /// <summary>
    /// User authentication provider.
    /// </summary>
    public interface IAuthenticationProvider
    {
        /// <summary>
        /// Active authenticated consumer.
        /// </summary>
        Credentials ActiveConsumer { get; }

        /// <summary>
        /// Authenticate the provided user.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="credentials">User credentials.</param>
        void Authenticate(string username, Credentials credentials);

        /// <summary>
        /// Logout.
        /// </summary>
        void Logout();
    }
}
