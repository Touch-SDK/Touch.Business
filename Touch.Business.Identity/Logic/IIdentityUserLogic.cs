using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Touch.Domain;

namespace Touch.Logic
{
    public interface IIdentityUserLogic<TUser>
        where TUser : IIdentityUser
    {
        void AddLogin(TUser user, UserLoginInfo login);

        Guid FindUserIdByLogin(UserLoginInfo login);

        TUser GetUserById(Guid userId);

        IList<UserLoginInfo> FindByUserId(Guid userId);

        void Delete(TUser user, UserLoginInfo login);

        void Insert(TUser user);

        void Delete(TUser user);

        TUser GetUserByName(string userName);

        void Update(TUser user);

        TUser GetUserByEmail(string email);

        string GenerateToken(string purpose, TUser user);

        void SendTokenNotification(string token, TUser user);

        bool ValidateToken(string purpose, string token, TUser user);
    }
}
