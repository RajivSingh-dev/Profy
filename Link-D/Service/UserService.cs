using Link_D.Models;

namespace Link_D.Service
{
    public class UserService : IUserService
    {

        private ProjectContext _projectContext;

        public UserService(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public void SaveUserData(User user)
        {
            _projectContext.Users.Add(user);

            _projectContext.SaveChanges();
        }
        
        public bool CheckUserExists(string email,string password)
        {

            return _projectContext.Users.Any(x => x.Email == email && x.Password == password);  
        }
    }
}
