using EduHome.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.ViewModel
{
    public class BlogpostVm
    {
        //post

        public Post Post { get; set; }
        public List<Post >Posts{ get; set; }




        //get
        public List<User> Users { get; set; }
        public List<BlogComment> Comments { get; set; }

    }
}
