using System;
using System.Security.Claims;
using Touch.Domain;

namespace Touch.Logic
{
    public interface IIdentityClaimLogic<TUser>
        where TUser : IIdentityUser
    {
        void Insert(Claim claim, Guid userId);

        ClaimsIdentity GetForUser(TUser user);

        void Delete(TUser user, Claim claim);
    }
}
