using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string MainImage { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required, MaxLength(250)]
        public string courtText { get; set; }
        [Required, MaxLength(700)]
        public string LongText { get; set; }
        public Feature Feature { get; set; }

        public List<CourseCategory> CourseCategories { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
