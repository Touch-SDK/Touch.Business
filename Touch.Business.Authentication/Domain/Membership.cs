using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// Access token.
    /// </summary>
    [DataContract(Name = "Membership")]
    public class Membership : Document
    {
        [DataMember(Name = "token", Order = 0)]
        public override string HashKey { get; set; }

        [DataMember(Name = "username", Order = 0)]
        public string UserName { get; set; }

        [DataMember(Name = "password", Order = 1)]
        public string Password { get; set; }

        [DataMember(Name = "salt", Order = 2)]
        public string Salt { get; set; }

        [DataMember(Name = "email", Order = 3)]
        public string Email { get; set; }

        [DataMember(Name = "is_approved", Order = 4)]
        public bool IsApproved { get; set; }

        [DataMember(Name = "is_lockeout", Order = 5)]
        public bool IsLockedOut { get; set; }

        [DataMember(Name = "create_date", Order = 6)]
        public DateTime CreateDate { get; set; }

        [DataMember(Name = "last_login_date", Order = 7)]
        public DateTime? LastLoginDate { get; set; }

        [DataMember(Name = "last_password_changed_date", Order = 8)]
        public DateTime? LastPasswordChangedDate { get; set; }

        [DataMember(Name = "last_locked_out_date", Order = 9)]
        public DateTime? LastLockedOutDate { get; set; }

        [DataMember(Name = "last_activity_date", Order = 10)]
        public DateTime? LastActivityDate { get; set; }

        [DataMember(Name = "failed_password_attempt_count", Order = 11)]
        public int FailedPasswordAttemptCount { get; set; }

        [DataMember(Name = "failed_password_attempt_window_start", Order = 12)]
        public DateTime? FailedPasswordAttemptWindowStart { get; set; }

        [DataMember(Name = "failed_password_answer_attempt_count", Order = 13)]
        public int FailedPasswordAnswerAttemptCount { get; set; }
    }
}
