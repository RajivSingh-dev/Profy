using System.ComponentModel.DataAnnotations.Schema;

namespace Link_D.Models
{
    public class Post
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PostBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastEdited { get; set; }
        public int LikesCount { get; set; }

        public int UserId { get; set; }   
        public User User { get; set; }
        public List<Comment> comments { get; set; }




    }
}
