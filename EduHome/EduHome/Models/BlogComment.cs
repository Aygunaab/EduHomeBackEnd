using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class BlogComment:BaseEntity
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
