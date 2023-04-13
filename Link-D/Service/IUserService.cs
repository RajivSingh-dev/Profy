using Link_D.Models;

namespace Link_D.Service
{
    public interface IUserService
    {
        public void SaveUserData(User user);

        public bool CheckUserExists(string email,string password);

    }
}
