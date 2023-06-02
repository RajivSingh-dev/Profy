using Link_D.Models.Api;
using Link_D.Models.Data;

namespace Link_D.Service
{
    public interface IPostService
    {
        public void SavePost(int userId, string description);
        public IList<Post> GetPosts(int userId);


    }
}
