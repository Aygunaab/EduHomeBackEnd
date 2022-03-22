using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Feature
    {
        [ForeignKey("Course")]
        public int Id{ get; set; }
        public DateTime Start { get; set; }
        public string ClassDuration { get; set; }
        public string Duration { get; set; }
        public string SkillLevel { get; set; }
        public string Language { get; set; }
        public int StudentsCount { get; set; }
        public string Assements { get; set; }
        public double CoursePrice { get; set; }
        public Course Course { get; set; }
    }
}
