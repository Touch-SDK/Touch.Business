using System;
using System.Collections.Generic;
using Touch.Domain;

namespace Touch.Logic
{
    public interface IIdentityRoleLogic<TUser>
        where TUser : IIdentityUser
    {
        string GetRoleId(string roleName);

        void Insert(TUser user, string roleId);

        IList<string> GetForUser(TUser user);
    }
}
