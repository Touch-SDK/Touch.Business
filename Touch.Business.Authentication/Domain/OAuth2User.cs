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
        /// Username.
        /// </summary>
        [DataMember(Name = "username", Order = 2)]
        public string UserName { get; set; }

        /// <summary>
        /// Roles.
        /// </summary>
        [DataMember(Name = "roles", Order = 3)]
        public string[] Roles { get; set; }
    }
}
