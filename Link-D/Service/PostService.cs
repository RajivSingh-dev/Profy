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
            _projectContext.post.Add(post);
            _projectContext.SaveChanges();


        }
    }
}
