using System.Runtime.Serialization;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth key pair.
    /// </summary>
    [DataContract(Name = "KeyPair")]
    sealed public class KeyPair
    {
        #region .ctor
        public KeyPair()
        {}

        public KeyPair(string key, string secret)
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
