using Link_D.Models.Api;

namespace Link_D.Service
{
    public interface IPostService
    {
        public void SavePost(int userId, string description);

    }
}
