using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// Nonce.
    /// </summary>
    [DataContract(Name = "ApiNonce")]
    public class Nonce : Document
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
