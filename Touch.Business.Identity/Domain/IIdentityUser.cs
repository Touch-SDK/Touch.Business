using System;
using Microsoft.AspNet.Identity;
using Touch.Persistence;

namespace Touch.Domain
{
    public interface IIdentityUser : IUser<Guid>, IBusinessEntity
    {
        new Guid Id { get; }

        new string UserName { get; set; }

        string Email { get; set; }

        string PasswordHash { get; set; }

        string SecurityStamp { get; set; }
    }
}
