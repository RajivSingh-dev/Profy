using LinkD.Models.Api;
using LinkD.Models.Data;
using Profy.LinkD.Data.Models;

namespace LinkD.Service
{
    public interface IPostService
    {
        public void SavePost(int userId, string description);
        public IList<Post> GetPosts(int userId);


    }
}
