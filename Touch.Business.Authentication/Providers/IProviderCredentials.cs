using System;
using Touch.Domain;
using System.ComponentModel;

namespace Touch.Providers
{
    /// <summary>
    /// Credentials provider.
    /// </summary>
    public interface IProviderCredentials : INotifyPropertyChanged
    {
        /// <summary>
        /// API application keys.
        /// </summary>
        KeyPair ApplicationKeys { get; set; }

        /// <summary>
        /// API access token.
        /// </summary>
        KeyPair AccessToken { get; set; }

        /// <summary>
        /// Set the credentials.
        /// </summary>
        /// <param name="credentials"></param>
        void SetCredentials(Credentials credentials);
    }
}
