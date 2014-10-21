using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth2 key.
    /// </summary>
    [DataContract]
    public class OAuth2Key : Document
    {
        /// <summary>
        /// Handle.
        /// </summary>
        [DataMember(Name = "token", Order = 1)]
        public override string HashKey { get; set; }

        /// <summary>
        /// Bucket.
        /// </summary>
        [DataMember(Name = "bucket", Order = 2)]
        public string Bucket { get; set; }

        /// <summary>
        /// Handle.
        /// </summary>
        [DataMember(Name = "handle", Order = 3)]
        public string Handle { get; set; }

        /// <summary>
        /// Secret.
        /// </summary>
        [DataMember(Name = "secret", Order = 4)]
        public string Secret { get; set; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        /// <see cref="DocumentUtil"/>
        [DataMember(Name = "expiration_date", Order = 5)]
        public string ExpirationDate { get; set; }
    }
}
