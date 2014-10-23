using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth request token.
    /// </summary>
    [DataContract]
    public class OAuthRequestToken : Document
    {
        /// <summary>
        /// Token.
        /// </summary>
        [DataMember(Name = "token", Order = 1)]
        public override string HashKey { get; set; }

        /// <summary>
        /// Token status.
        /// </summary>
        [DataMember(Name = "status", Order = 2)]
        public string Status { get; set; }

        /// <summary>
        /// Consumer key.
        /// </summary>
        [DataMember(Name = "consumer", Order = 3)]
        public string Consumer { get; set; }

        /// <summary>
        /// Token secret.
        /// </summary>
        [DataMember(Name = "secret", Order = 4)]
        public string Secret { get; set; }

        /// <summary>
        /// Issue date.
        /// </summary>
        /// <see cref="DocumentUtil"/>
        [DataMember(Name = "issued", Order = 5)]
        public string IssueDate { get; set; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        /// <see cref="DocumentUtil"/>
        [DataMember(Name = "expires", Order = 6)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Linked access token (if any).
        /// </summary>
        [DataMember(Name = "access_token", Order = 7)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Shorthand code.
        /// </summary>
        [DataMember(Name = "shorthand", Order = 8)]
        public string Shorthand { get; set; }

        /// <summary>
        /// Verification code.
        /// </summary>
        [DataMember(Name = "verification", Order = 9)]
        public string Verification { get; set; }

        /// <summary>
        /// Realm.
        /// </summary>
        [DataMember(Name = "realm", Order = 10)]
        public string Realm { get; set; }

        /// <summary>
        /// Callback url.
        /// </summary>
        [DataMember(Name = "callback_url", Order = 11)]
        public string CallbackUrl { get; set; }
    }
}
