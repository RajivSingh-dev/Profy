using Link_D.Models.Api;
using Link_D.Models.Data;

namespace Link_D.Service
{
    public interface IUserService
    {
         bool SaveUserData(User user);

         int? CheckUserExists(Login model);

         bool VerifyPassword(int? userId,string password);


    }
}
