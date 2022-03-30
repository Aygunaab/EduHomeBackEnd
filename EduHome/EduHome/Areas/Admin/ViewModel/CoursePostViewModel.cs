using EduHome.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.ViewModel
{
    public class CoursePostViewModel
    {
        public string Image { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required, MaxLength(250)]
        public string courtText { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public string ClassDuration { get; set; }
        public string Duration { get; set; }
        public string SkillLevel { get; set; }
        public string Language { get; set; }
        public int StudentsCount { get; set; }
        public string Assements { get; set; }
        public double CoursePrice { get; set; }


        public IFormFile ImageFile { get; set; }

        public List<int> CategoryIds { get; set; }


        public List<Category> Categories { get; set; }
     
       

    }
}
