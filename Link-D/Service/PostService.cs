using Link_D.Models.Data;

namespace Link_D.Service
{
    public class PostService : IPostService
    {
        private ProjectContext _projectContext;

        public PostService(ProjectContext projectContext)
        { 
        _projectContext = projectContext;
        }

   
        public void SavePost(int userId, string description)
        {
            Post post = new Post();
            post.UserId = userId;
            post.Description = description;
            _projectContext.posts.Add(post);
            _projectContext.SaveChanges();

        }

        public IList<Post> GetPosts(int userId) 
        { 
             return _projectContext.posts.Where(post => post.UserId == userId).ToList();
        }

    }
}
