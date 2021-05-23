using System;
using System.Collections.Generic;

#nullable disable

namespace BlogPosts.Models
{
    public partial class UserPost
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
