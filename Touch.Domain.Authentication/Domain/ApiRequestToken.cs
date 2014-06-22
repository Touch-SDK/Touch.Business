using System;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// API request token.
    /// </summary>
    abstract public class ApiRequestToken : BusinessEntity
    {
        /// <summary>
        /// Related consumer.
        /// </summary>
        public virtual ApiConsumer Consumer { get; set; }

        /// <summary>
        /// Token.
        /// </summary>
        public virtual string Token { get; set; }

        /// <summary>
        /// Secret key.
        /// </summary>
        public virtual string Secret { get; set; }

        /// <summary>
        /// Shorthand code.
        /// </summary>
        public virtual string Shorthand { get; set; }

        /// <summary>
        /// Verification code.
        /// </summary>
        public virtual string Verification { get; set; }

        /// <summary>
        /// Issue date.
        /// </summary>
        public virtual DateTime Issued { get; set; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        public virtual DateTime Expires { get; set; }

        /// <summary>
        /// Callback URL.
        /// </summary>
        public virtual string CallbackUrl { get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        public virtual RequestTokenStatus Status { get; set; }

        /// <summary>
        /// Linked access token.
        /// </summary>
        public virtual ApiAccessToken AccessToken { get; set; }
    }
}
