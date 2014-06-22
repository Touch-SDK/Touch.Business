using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// API consumer.
    /// </summary>
    abstract public class ApiConsumer : BusinessEntity
    {
        /// <summary>
        /// Token.
        /// </summary>
        public virtual string Token { get; set; }

        /// <summary>
        /// Secret key.
        /// </summary>
        public virtual string Secret { get; set; }

        /// <summary>
        /// Roles.
        /// </summary>
        public virtual byte Roles { get; set; }
    }
}
