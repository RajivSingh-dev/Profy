using LinkD.Models.Api;
using LinkD.Models.Data;
using Microsoft.AspNetCore.Identity;
using Profy.LinkD.Data.Models;

namespace LinkD.Service
{
    public class UserService : IUserService
    {

        private ProjectContext _projectContext;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(ProjectContext projectContext,IPasswordHasher<User> passwordHasher)
        {
            _projectContext = projectContext;
            _passwordHasher = passwordHasher;
        }

        public bool SaveUserData(User user)
        {
            var hashedPassword = _passwordHasher.HashPassword(user, user.Password);
            user.PasswordHash = hashedPassword;
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

            if (userId == null) return false;
            User user = _projectContext.Users.Find(userId);
            if (user == null) return false;
            string hashedPassword = user.PasswordHash;
            PasswordVerificationResult result = new PasswordHasher<User>().VerifyHashedPassword(user, hashedPassword, password);
            return result == PasswordVerificationResult.Success;
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
