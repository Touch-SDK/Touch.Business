using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth2 API access.
    /// </summary>
    [DataContract]
    public class OAuth2Access : Document
    {
        public OAuth2Access()
        {
            ExtraData = new Dictionary<string, string>();
        }

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
        /// Issue date.
        /// </summary>
        [DataMember(Name = "issue_date", Order = 3)]
        public string IssueDate { get; set; }

        /// <summary>
        /// Roles.
        /// </summary>
        [DataMember(Name = "roles", Order = 4)]
        public string[] Roles { get; set; }

        /// <summary>
        /// Extra data.
        /// </summary>
        [DataMember(Name = "extra_data", Order = 5)]
        public IDictionary<string, string> ExtraData { get; set; }
    }
}
