using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Skill
    {
        
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public List<SkillsToTeacher> SkillsToTeachers { get; set; }
    }
}
