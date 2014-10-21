using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth2 user.
    /// </summary>
    [DataContract]
    public class OAuth2User : Document
    {
        /// <summary>
        /// Token.
        /// </summary>
        [DataMember(Name = "token", Order = 1)]
        public override string HashKey { get; set; }

        /// <summary>
        /// Client ID.
        /// </summary>
        [DataMember(Name = "client_id", Order = 2)]
        public string ClientId { get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [DataMember(Name = "username", Order = 3)]
        public string UserName { get; set; }

        /// <summary>
        /// Roles.
        /// </summary>
        [DataMember(Name = "roles", Order = 4)]
        public string[] Roles { get; set; }
    }
}
