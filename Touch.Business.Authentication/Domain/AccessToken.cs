using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// Access token.
    /// </summary>
    [DataContract(Name = "ApiAccessToken")]
    public class AccessToken : Document
    {
        /// <summary>
        /// Token.
        /// </summary>
        [DataMember(Name = "token", Order = 1)]
        public override string HashKey { get; set; }

        /// <summary>
        /// Consumer key.
        /// </summary>
        [DataMember(Name = "consumer", Order = 2)]
        public string Consumer { get; set; }

        /// <summary>
        /// Token secret.
        /// </summary>
        [DataMember(Name = "secret", Order = 3)]
        public string Secret { get; set; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        /// <see cref="DocumentUtil"/>
        [DataMember(Name = "expires", Order = 4)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Granted roles.
        /// </summary>
        [DataMember(Name = "roles", Order = 6)]
        public string Roles { get; set; }
    }
}
