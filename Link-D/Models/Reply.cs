namespace Link_D.Models
{
    public class Reply
    {

        public int Id { get; set; }
        public string Content { get; set; }
        
        public int CommentId { get; set; }
        public Comment CommentComment { get; set; }



    }
}
