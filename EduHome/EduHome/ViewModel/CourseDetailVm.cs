using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModel
{
    public class CourseDetailVm
    {
        //get
        public Course Courses { get; set; }
        public List<Category>Categorys { get; set; }
        public List<CourseCategory> courseCategories { get; set; }
        public CommentPostVm Comment { get; set; }


    }
}
