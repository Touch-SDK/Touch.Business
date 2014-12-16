using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth2 client.
    /// </summary>
    [DataContract]
    public class OAuth2Client : Document
    {
        /// <summary>
        /// Token.
        /// </summary>
        [DataMember(Name = "token", Order = 1)]
        public override string HashKey { get; set; }

        /// <summary>
        /// Secret.
        /// </summary>
        [DataMember(Name = "secret", Order = 2)]
        public string Secret { get; set; }

        /// <summary>
        /// Is public client.
        /// </summary>
        [DataMember(Name = "is_public", Order = 3)]
        public bool IsPublic { get; set; }

        /// <summary>
        /// Callback URL.
        /// </summary>
        [DataMember(Name = "callback", Order = 4)]
        public string Callback { get; set; }

        /// <summary>
        /// Roles.
        /// </summary>
        [DataMember(Name = "roles", Order = 5)]
        public string[] Roles { get; set; }
    }
}
