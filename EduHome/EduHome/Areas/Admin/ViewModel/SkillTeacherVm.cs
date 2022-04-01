using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.ViewModel
{
    public class SkillTeacherVm
    {
        public int Progress { get; set; }
        public int SkillId{ get; set; }
        public int TeacherId { get; set; }


        //get

        public List<Teacher> Teachers { get; set; }
        public SkillsToTeacher SkillTeachers { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
