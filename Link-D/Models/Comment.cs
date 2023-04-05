﻿using System.Reflection.Metadata;

namespace Link_D.Models
{
    public class Comment
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime LastEdited { get; set; }


        public int PostId { get; set; }
        public Post post { get; set; }

    }
}
