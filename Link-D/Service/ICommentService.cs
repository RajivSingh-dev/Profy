namespace Link_D.Service
{
    public interface ICommentService
    {

        public string GetDescription(int id);

        public DateTime GetCreatedOn(int id);

    }
}
