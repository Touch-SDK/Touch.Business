using System;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// API access token.
    /// </summary>
    abstract public class ApiAccessToken : BusinessEntity
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
        /// Issue date.
        /// </summary>
        public virtual DateTime Issued { get; set; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        public virtual DateTime Expires { get; set; }

        /// <summary>
        /// Token has been revoked.
        /// </summary>
        public virtual bool IsRevoked { get; set; }
    }
}
