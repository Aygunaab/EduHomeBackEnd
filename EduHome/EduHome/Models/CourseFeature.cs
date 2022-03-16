using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseFeature
    {
        public int Id { get; set; }
        [Required]
        public DateTime Starts { get; set; }
        [Required]
        public string  Duration { get; set; }
        [Required]
        public string ClassDuration { get; set; }
        [Required]
        public string SkillLevel { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public int StudentsCount { get; set; }
        [Required]
        public string Assement { get; set; }
        [Required]
        public double CoursePrice { get; set; }
    }
}
