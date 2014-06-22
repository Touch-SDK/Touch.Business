using System;

namespace Touch.Domain
{
    /// <summary>
    /// Request token status.
    /// </summary>
    public enum RequestTokenStatus : byte
    {
        /// <summary>
        /// Token is valid.
        /// </summary>
        Valid = 0,

        /// <summary>
        /// Token had been used up.
        /// </summary>
        UsedUp = 1,

        /// <summary>
        /// Access denied.
        /// </summary>
        Denied = 2
    }
}
