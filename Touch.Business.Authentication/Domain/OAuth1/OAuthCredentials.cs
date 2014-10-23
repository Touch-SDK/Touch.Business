using System.Runtime.Serialization;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth credentials.
    /// </summary>
    [DataContract]
    public class OAuthCredentials
    {
        /// <summary>
        /// Consumer key pair.
        /// </summary>
        [DataMember(Name = "consumer", Order = 1)]
        public OAuthKeyPair Consumer { get; set; }

        /// <summary>
        /// Access token key pair.
        /// </summary>
        [DataMember(Name = "token", Order = 2)]
        public OAuthKeyPair Token { get; set; }
    }
}
