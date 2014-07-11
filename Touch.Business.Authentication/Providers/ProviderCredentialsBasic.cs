using System;
using System.Text;
using System.ComponentModel;

using Touch.Domain;
using Touch.Persistence;
using Touch.Serialization;
using Touch.Helpers;

namespace Touch.Providers
{
    /// <summary>
    /// Credentials provider.
    /// </summary>
    sealed public class ProviderCredentialsBasic : IProviderCredentials
    {
        #region IProviderApiCredentials implementation
        public KeyPair ApplicationKeys
        {
            get;
            set;
        }

        public KeyPair AccessToken
        {
            get;
            set;
        }

        public void SetCredentials(Credentials credentials)
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
