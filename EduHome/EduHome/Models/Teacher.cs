using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Surname { get; set; }

        [MaxLength(20)]
        public string Profession { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Degree { get; set; }

        [MaxLength(50)]
        public string Experience { get; set; }

        [MaxLength(50)]
        public string Hobbies { get; set; }

        [MaxLength(50)]
        public string Faculty { get; set; }

        [MaxLength(50)]
        public string Mail { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        public List<SocialToTeacher> SocialToTeachers { get; set; }
        public List<SkillsToTeacher> SkillsToTeachers { get; set; }

    }
}
