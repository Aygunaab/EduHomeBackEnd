using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 300)]
        public string BackgroundImage { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Title { get; set; }
        [Required]
       [StringLength(maximumLength:500)]
        public string Description { get; set; }
        [Required]
        public int Order { get; set; }

    }
}
