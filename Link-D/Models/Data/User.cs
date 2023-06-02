using System.ComponentModel.DataAnnotations;

namespace Link_D.Models.Data
{
    public class User
    {

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Profile { get; set; } = "Associate Software Engineer";

       
        public IList<Post>? Posts { get; set; }

    }
}
