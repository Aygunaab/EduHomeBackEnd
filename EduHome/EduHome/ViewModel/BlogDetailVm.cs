using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModel
{
    public class BlogDetailVm
    {
        public Post Posts { get; set; }

        public BlogCommentVm Comment { get; set; }
        public User User { get; set; }
    }
}
