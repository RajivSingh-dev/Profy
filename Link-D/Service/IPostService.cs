using LinkD.Models.Api;
using LinkD.Models.Data;

namespace LinkD.Service
{
    public interface IPostService
    {
        public void SavePost(int userId, string description);
        public IList<Post> GetPosts(int userId);


    }
}
