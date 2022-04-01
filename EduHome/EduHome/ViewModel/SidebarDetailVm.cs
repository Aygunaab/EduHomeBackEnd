using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModel
{
    public class SidebarDetailVm
    {
        public List<Category > Categories { get; set; }
        public List<CourseCategory >CourseCategories { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public List<Post> Posts { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
