using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Touch.Domain;

namespace Touch.Logic
{
    /// <summary>
    /// Membership logic.
    /// </summary>
    public abstract class MembershipLogic
    {
        /// <summary>
        /// Get user membership by token.
        /// </summary>
        /// <returns>Membership instance of <c>null</c> if user not found.</returns>
        public abstract Membership GetUserByToken(string token);

        /// <summary>
        /// Get user membership by user name.
        /// </summary>
        /// <returns>Membership instance of <c>null</c> if user not found.</returns>
        public abstract Membership GetUserByName(string username);

        /// <summary>
        /// Get user name by e-mail.
        /// </summary>
        /// <returns>User name of <c>null</c> if user not found.</returns>
        public abstract string GetUserNameByEMail(string email);

        /// <summary>
        /// Persist new user membership.
        /// </summary>
        public abstract void SaveUser(Membership membership);

        /// <summary>
        /// Persist existing user membership.
        /// </summary>
        public abstract void UpdateUser(Membership membership);

        /// <summary>
        /// Delete existing user membership.
        /// </summary>
        public abstract void DeleteUser(Membership membership);

        /// <summary>
        /// Get all existing users within a range.
        /// </summary>
        public abstract IEnumerable<Membership> GetAllUsers(int pageIndex, int pageSize);

        /// <summary>
        /// Count the online users.
        /// </summary>
        public abstract int CountOnlineUsers(DateTime compareTime);
    }
}
