using Link_D.Models.Api;
using Link_D.Models.Data;

namespace Link_D.Service
{
    public class UserService : IUserService
    {

        private ProjectContext projectContext;

        public UserService(ProjectContext projectContext)
        {
            this.projectContext = projectContext;
        }

        public bool SaveUserData(User user)
        {

            if (!IsNew(user.Email))
            {
                projectContext.Users.Add(user);
                projectContext.SaveChanges();
                return true;
            }


            return false;
        }
        
        public bool CheckUserExists(Login model)
        {

            return projectContext.Users.Any(x => x.Email == model.Email && x.Password == model.Password);  
        }

        public bool IsNew(string email) {

            return projectContext.Users.Any(u => u.Email == email);
        
        }
    }
}
