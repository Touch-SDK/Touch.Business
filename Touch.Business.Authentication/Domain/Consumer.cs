using System;
using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// Consumer.
    /// </summary>
    [DataContract(Name = "ApiConsumer")]
    public class Consumer : Document
    {
        /// <summary>
        /// Consumer key.
        /// </summary>
        [DataMember(Name = "key", Order = 1)]
        public override string HashKey { get; set; }

        /// <summary>
        /// Consumer secret.
        /// </summary>
        [DataMember(Name = "secret", Order = 2)]
        public string Secret { get; set; }
    }
}
