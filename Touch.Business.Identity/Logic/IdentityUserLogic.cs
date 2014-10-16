using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Touch.Domain;

namespace Touch.Logic
{
    public abstract class IdentityUserLogic<TUser>
        where TUser : IIdentityUser
    {
        #region Public methods
        public abstract void AddLogin(TUser user, UserLoginInfo login);

        public abstract Guid FindUserIdByLogin(UserLoginInfo login);

        public abstract TUser GetUserById(Guid userId);

        public abstract IList<UserLoginInfo> FindByUserId(Guid userId);

        public abstract void Delete(TUser user, UserLoginInfo login);

        public abstract void Insert(TUser user);

        public abstract void Delete(TUser user);

        public abstract TUser GetUserByName(string userName);

        public abstract void Update(TUser user);

        public abstract string GetPasswordHash(Guid userId);

        public abstract TUser GetUserByEmail(string email);

        #endregion
    }
}
