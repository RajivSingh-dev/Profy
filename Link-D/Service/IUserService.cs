using LinkD.Models.Api;
using Profy.LinkD.Data.Models;

namespace LinkD.Service
{
    public interface IUserService
    {
        bool SaveUserData(User user);
        int? CheckUserExists(Login model);
        bool VerifyPassword(int? userId, string password);
        public User GetUser(int userId);


    }
}
