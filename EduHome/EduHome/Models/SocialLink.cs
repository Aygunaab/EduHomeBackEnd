using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class SocialLink
    {
        public int Id { get; set; }
        public string FacebookLink { get; set; }
        public string PinterestLink { get; set; }
        public string VimeoLink { get; set; }
        public string TwitterLink { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
