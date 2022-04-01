using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.ViewModel
{
    public class SocialTeacherVm
    {
        public string Link { get; set; }
        public int SocialId { get; set; }
        public int TeacherId { get; set; }


        //get

        public List<Teacher> Teachers { get; set; }
        public SocialToTeacher SocialTeachers { get; set; }
        public List<Social> Socials { get; set; }

    }
}
