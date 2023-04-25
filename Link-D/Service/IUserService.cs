using Link_D.Models.Api;
using Link_D.Models.Data;

namespace Link_D.Service
{
    public interface IUserService
    {
        public bool SaveUserData(User user);

        public bool CheckUserExists(Login model);

    }
}
