using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class SocialToTeacher
    {
        public int Id { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }
        public int SocialId { get; set; }

        public Social Social { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
