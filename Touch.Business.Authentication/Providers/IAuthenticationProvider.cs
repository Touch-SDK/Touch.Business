using System;
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
        [Obsolete]
        Credentials ActiveConsumer { get; }

        /// <summary>
        /// Active authenticated user.
        /// </summary>
        OAuth2User ActiveUser { get; }
    }
}
