using System.Runtime.Serialization;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth key pair.
    /// </summary>
    [DataContract]
    sealed public class OAuthKeyPair
    {
        #region .ctor
        public OAuthKeyPair()
        {}

        public OAuthKeyPair(string key, string secret)
        {
            Key = key;
            Secret = secret;
        }
        #endregion

        /// <summary>
        /// Public key.
        /// </summary>
        [DataMember(Name = "key", Order = 1)]
        public string Key { get; set; }

        /// <summary>
        /// Secret key.
        /// </summary>
        [DataMember(Name = "secret", Order = 2)]
        public string Secret { get; set; }
    }
}
