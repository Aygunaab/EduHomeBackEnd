using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class SkillsToTeacher
    {
       
        public int Id { get; set; }

        public int Progress { get; set; }
        public int SkillsId { get; set; }

        public Skill Skills { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
