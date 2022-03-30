using EduHome.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.ViewModel
{
    public class TeacherVm
    {
        public IFormFile ImageFile { get; set; }
        [Required, MaxLength(30)]
        public string Fullname { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required, MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string Experiance { get; set; }

        public string Hobbies { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Number { get; set; }
        public string Skype { get; set; }
        public int SocialId { get; set; }
        public int SkillId { get; set; }
        public List<SocialLink> Socials { get; set; }
        public List<Skill> Skills { get; set; }

        public int PositionId { get; set; }
        public List<Position> Positions { get; set; }

    }
}
