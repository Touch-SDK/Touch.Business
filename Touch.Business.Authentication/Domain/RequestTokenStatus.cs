using System;
using System.Runtime.Serialization;

namespace Touch.Domain
{
    [DataContract]
    /// <summary>
    /// Request token status.
    /// </summary>
    public enum RequestTokenStatus : byte
    {
        [EnumMember(Value = "0")]
        /// <summary>
        /// Token is valid.
        /// </summary>
        Valid = 0,

        [EnumMember(Value = "1")]
        /// <summary>
        /// Token had been used up.
        /// </summary>
        UsedUp = 1,

        [EnumMember(Value = "2")]
        /// <summary>
        /// Access denied.
        /// </summary>
        Denied = 2
    }

    /// <summary>
    /// Request token statuses.
    /// </summary>
    public static class RequestTokenStatuses
    {
        public const string Valid = "Valid";

        public const string UsedUp = "UsedUp";

        public const string Denied = "Denied";

        /// <summary>
        /// Convert string value into a <c>RequestTokenStatus</c> value.
        /// </summary>
        static public RequestTokenStatus ToStatus(string status)
        {
            RequestTokenStatus result;
            return Enum.TryParse(status, true, out result)
                ? result
                : RequestTokenStatus.Denied;
        }
    }

    #region Extension
    /// <summary>
    /// <c>RequestToken</c> extension.
    /// </summary>
    /// <see cref="RequestToken"/>
    static public class RequestTokenExtension
    {
        /// <summary>
        /// Convert <c>RequestToken</c> to a string value.
        /// </summary>
        static public string ToStatus(this RequestTokenStatus value)
        {
            return value.ToString();
        }
    }
    #endregion
}
