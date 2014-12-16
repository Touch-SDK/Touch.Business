using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth2 client.
    /// </summary>
    [DataContract]
    public class OAuth2Nonce : Document
    {
        /// <summary>
        /// Token.
        /// </summary>
        [DataMember(Name = "token", Order = 1)]
        public override string HashKey { get; set; }

        /// <summary>
        /// Nonce.
        /// </summary>
        [DataMember(Name = "nonce", Order = 2)]
        public string Nonce { get; set; }

        /// <summary>
        /// Context.
        /// </summary>
        [DataMember(Name = "context", Order = 3)]
        public string Context { get; set; }

        /// <summary>
        /// Issue date.
        /// </summary>
        /// <see cref="DocumentUtil"/>
        [DataMember(Name = "issue_date", Order = 4)]
        public string IssueDate { get; set; }
    }
}
