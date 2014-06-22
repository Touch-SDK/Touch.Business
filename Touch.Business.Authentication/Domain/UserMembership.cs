using System;
using Touch.Persistence;

namespace Touch.Domain
{
    /// <summary>
    /// User membership.
    /// </summary>
    public class UserMembership : Entity
    {
        public virtual string Password { get; set; }

        public virtual string Salt { get; set; }

        public virtual string Email { get; set; }

        public virtual bool IsApproved { get; set; }

        public virtual bool IsLockedOut { get; set; }

        public virtual DateTime CreateDate { get; set; }

        public virtual DateTime? LastLoginDate { get; set; }

        public virtual DateTime? LastPasswordChangedDate { get; set; }

        public virtual DateTime? LastLockedOutDate { get; set; }

        public virtual DateTime? LastActivityDate { get; set; }

        public virtual int FailedPasswordAttemptCount { get; set; }

        public virtual DateTime? FailedPasswordAttemptWindowStart { get; set; }

        public virtual int FailedPasswordAnswerAttemptCount { get; set; }

        public virtual DateTime? FailedPasswordAnswerAttemptWindowStart { get; set; }
    }
}
