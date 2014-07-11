using System;
using System.Collections.Generic;
using System.Text;
using Touch.Domain;
using Touch.Persistence;
using Touch.Serialization;

namespace Touch.Logic
{
    public abstract class AuthenticationLogic : BusinessLogic
    {
        #region Dependencies
        public IRepositoryProvider RepositoryProvider { protected get; set; }
        public IHashGenerator TokenHashGenerator { protected get; set; }
        public IEncrypter TokenEncrypter { protected get; set; }
        #endregion

        #region Data
        protected readonly Random RandomNumber = new Random();
        protected const string RandomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        #endregion

        #region Public methods
        /// <summary>
        /// Generate an API token.
        /// </summary>
        public virtual string GenerateApiToken()
        {
            const int length = 21;
            var buffer = new char[length];

            for (var i = 0; i < length; i++)
                buffer[i] = RandomCharacters[RandomNumber.Next(RandomCharacters.Length)];

            return new string(buffer);
        }

        /// <summary>
        /// Generate an API nonce.
        /// </summary>
        public virtual string GenerateApiNonce()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 16).ToLower();
        }

        /// <summary>
        /// Generate an API secret.
        /// </summary>
        /// <param name="token">API token.</param>
        public virtual string GenerateApiSecret(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) throw new ArgumentNullException("token");

            var baseString = Encoding.UTF8.GetBytes(token);
            var salt = Encoding.UTF8.GetBytes(Guid.NewGuid().ToString());

            var hash = TokenEncrypter.Crypt(baseString, salt);
            var result = TokenHashGenerator.Generate(hash);

            return result;
        }

        /// <summary>
        /// Generate a PIN code.
        /// </summary>
        public virtual string GeneratePinCode()
        {
            const int length = 5;
            var result = new StringBuilder(length);

            for (var i = 0; i < length; i++)
                result.Append(RandomNumber.Next(1, 9));

            return result.ToString();
        }
        #endregion

        #region Abstract methods
        /// <summary>
        /// Get OAuth consumer by its consumer token key.
        /// </summary>
        /// <returns>Consumer object or <c>null</c> if consumer not found.</returns>
        public abstract Consumer GetConsumer(string consumerToken);

        /// <summary>
        /// Get an OAuth access token by its token key.
        /// </summary>
        /// <returns>Token object or <c>null</c> if token not found.</returns>
        public abstract AccessToken GetAccessToken(string token);

        /// <summary>
        /// Get an OAuth request token by its token key.
        /// </summary>
        /// <returns>Token object or <c>null</c> if token not found.</returns>
        public abstract RequestToken GetRequestToken(string token);

        /// <summary>
        /// Issue a new OAuth request token.
        /// </summary>
        public abstract RequestToken IssueRequestToken(string consumerKey, string realm, string callbackUrl = null);

        /// <summary>
        /// Grant a new OAuth access token for the consumer.
        /// </summary>
        public abstract AccessToken GrantApiAccess(string consumerToken);

        /// <summary>
        /// Consume the OAuth request token.
        /// </summary>
        /// <returns><c>true</c> if token has been found and consumed, <c>false</c> otherwise.</returns>
        public abstract bool ConsumeRequestToken(string token);

        /// <summary>
        /// Consume the OAuth access token.
        /// </summary>
        /// <returns><c>true</c> if token has been found and consumed, <c>false</c> otherwise.</returns>
        public abstract bool ConsumeAccessToken(string token);

        /// <summary>
        /// Consume the OAuth nonce.
        /// </summary>
        /// <returns><c>true</c> if nonce has been found and consumed, <c>false</c> otherwise.</returns>
        public abstract bool ConsumeNonce(string nonce);
        #endregion
    }
}
