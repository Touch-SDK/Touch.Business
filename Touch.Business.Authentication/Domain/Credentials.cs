using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Touch.Domain
{
    /// <summary>
    /// OAuth credentials.
    /// </summary>
    [DataContract(Name = "Credentials")]
    public class Credentials
    {
        /// <summary>
        /// Consumer key pair.
        /// </summary>
        [DataMember(Name = "consumer", Order = 1)]
        public KeyPair Consumer { get; set; }

        /// <summary>
        /// Access token key pair.
        /// </summary>
        [DataMember(Name = "token", Order = 2)]
        public KeyPair Token { get; set; }
    }
}
