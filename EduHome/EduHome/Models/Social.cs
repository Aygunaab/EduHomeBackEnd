using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Social
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }


        public List<SocialToTeacher> SocialToTeachers { get; set; }
    }
}
