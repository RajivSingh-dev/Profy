﻿namespace Link_D.Models
{
    public class User
    {

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       


        public List<Post>? Posts { get; set; }



    }
}
