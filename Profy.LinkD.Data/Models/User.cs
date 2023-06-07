using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profy.LinkD.Data.Models
{
    public class User : IdentityUser
    {

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Profile { get; set; } = "Associate Software Engineer";
        [NotMapped]
        public string Password { get; set; }

       
        public IList<Post>? Posts { get; set; }

    }
}
