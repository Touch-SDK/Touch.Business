using System;
using System.Security.Claims;
using Touch.Domain;

namespace Touch.Logic
{
    public abstract class IdentityClaimLogic<TUser>
        where TUser : IIdentityUser
    {
        #region Public methods
        public abstract void Insert(Claim claim, Guid userId);

        public abstract ClaimsIdentity GetForUser(TUser user);

        public abstract void Delete(TUser user, Claim claim);
        #endregion
    }
}
