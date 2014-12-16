using System;
using Microsoft.AspNet.Identity;
using Touch.Domain;

namespace Touch.Providers
{
    public sealed class IdentityProvider<TUser> : UserManager<TUser, Guid>
        where TUser : class, IIdentityUser
    {
        public IdentityProvider(IUserStore<TUser, Guid> store)
            : base(store)
        { }
    }
}
