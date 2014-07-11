using System;
using Touch.Domain;
using System.ComponentModel;

namespace Touch.Providers
{
    public abstract class AbstractProviderCredentials : IProviderCredentials
    {
        #region Protected methods
        protected abstract Credentials ActiveCredentials { get; set; }

        protected abstract Credentials ReadCredentials();

        public abstract void SetCredentials(Credentials credentials);
        #endregion

        #region IProviderCredentials implementation
        public KeyPair ApplicationKeys
        {
            get
            {
                return ActiveCredentials != null && ActiveCredentials.Consumer != null &&
                    !string.IsNullOrEmpty(ActiveCredentials.Consumer.Key) && !string.IsNullOrEmpty(ActiveCredentials.Consumer.Secret)
                    ? ActiveCredentials.Consumer
                        : null;
            }
            set
            {
                var credentials = ActiveCredentials ?? new Credentials();

                if (string.IsNullOrEmpty(value.Key) || string.IsNullOrEmpty(value.Secret))
                    value = null;

                credentials.Consumer = value;
                SetCredentials(credentials);
                OnPropertyChanged("ApplicationKeys");
            }
        }

        public KeyPair AccessToken
        {
            get
            {
                return ActiveCredentials != null && ActiveCredentials.Token != null &&
                    !string.IsNullOrEmpty(ActiveCredentials.Token.Key) && !string.IsNullOrEmpty(ActiveCredentials.Token.Secret)
                    ? ActiveCredentials.Token
                        : null;
            }
            set
            {
                var credentials = ActiveCredentials ?? new Credentials();

                if (string.IsNullOrEmpty(value.Key) || string.IsNullOrEmpty(value.Secret))
                    value = null;

                credentials.Token = value;
                SetCredentials(credentials);
                OnPropertyChanged("AccessToken");
            }
        }
        #endregion

        #region INotifyPropertyChanged members
        /// <summary>
        /// Raised when object's property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            new PropertyChangedEventArgs(name).Raise(this, ref PropertyChanged);
        }
        #endregion
    }
}

