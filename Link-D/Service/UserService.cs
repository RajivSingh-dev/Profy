using LinkD.Models.Api;
using LinkD.Models.Data;



namespace LinkD.Service
{
    public class UserService : IUserService
    {

        private ProjectContext _projectContext;

        public UserService(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public bool SaveUserData(User user)
        {

            if (!IsNew(user.Email))
            {
                _projectContext.Users.Add(user);
                _projectContext.SaveChanges();
                return true;
            }


            return false;
        }
        
        public int? CheckUserExists(Login model)
        {
            return _projectContext.Users.FirstOrDefault(x => x.Email == model.Email)?.Id;
         
        }

        public bool IsNew(string email) {

            return _projectContext.Users.Any(u => u.Email == email);
        
        }

        public bool VerifyPassword(int? userId, string password)
        {
            return userId != null && _projectContext.Users.Any(x => x.Id == userId && x.Password == password);
        }

        public User GetUser(int userId) 
        {
            return _projectContext.Users.Find(userId);
        }

        public IList<Post> GetPosts(int userId)
        {

            return _projectContext.Users.Find(userId).Posts;
        }
    }
}   
