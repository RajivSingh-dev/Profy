using Link_D.Models.Data;

namespace Link_D.Service
{
    public class CommentService : ICommentService
    {
        private  ProjectContext _projectContext;

        public CommentService(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public string GetDescription(int id)
        {

            return "";
        } 
        
        public DateTime GetCreatedOn(int id)
        {

            return DateTime.Now;
        }

    }

}
