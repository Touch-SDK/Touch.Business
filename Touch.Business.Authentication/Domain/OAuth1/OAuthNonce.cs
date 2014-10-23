using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth nonce.
    /// </summary>
    [DataContract]
    public class OAuthNonce : Document
    {
        /// <summary>
        /// Nonce.
        /// </summary>
        [DataMember(Name = "nonce", Order = 1)]
        public override string HashKey { get; set; }

        /// <summary>
        /// Issue date.
        /// </summary>
        /// <see cref="DocumentUtil"/>
        [DataMember(Name = "issued", Order = 2)]
        public string IssueDate { get; set; }
    }
}
