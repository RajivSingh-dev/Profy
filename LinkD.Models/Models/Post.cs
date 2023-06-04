using System.ComponentModel.DataAnnotations.Schema;

namespace LinkD.Models.Data
{
    public class Post
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastEdited { get; set; }
        public int LikesCount { get; set; }
       

        public int UserId { get; set; }
        public List<Comment> comments { get; set; }




    }
}
