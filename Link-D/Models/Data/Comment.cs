using System.Reflection.Metadata;

namespace Link_D.Models.Data
{
    public class Comment
    {

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime LastEdited { get; set; }


        public int PostId { get; set; }
        public Post post { get; set; }
        public List<Reply> reply { get; set; }

    }
}
