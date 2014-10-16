using System;
using System.Collections.Generic;
using Touch.Domain;

namespace Touch.Logic
{
    public abstract class IdentityRoleLogic<TUser>
        where TUser : IIdentityUser
    {
        #region Public methods
        public abstract string GetRoleId(string roleName);

        public abstract void Insert(TUser user, string roleId);

        public abstract IList<string> GetForUser(TUser user);
        #endregion
    }
}
