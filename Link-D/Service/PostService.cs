using LinkD.Models.Data;

namespace LinkD.Service
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
            post.CreatedOn= DateTime.Now;
            post.LastEdited= DateTime.Now;
            post.Description= description;
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
