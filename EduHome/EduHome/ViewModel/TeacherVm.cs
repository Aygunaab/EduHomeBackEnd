using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModel
{
    public class TeacherVm
    {
        public Teacher Teacher { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<SocialToTeacher> SocialToTeacher { get; set; }
        public List<Social> Socials{ get; set; }
        public List<SkillsToTeacher>SkillsToTeachers { get; set; }
        public List<Skill> Skills{ get; set; }

    }
}
