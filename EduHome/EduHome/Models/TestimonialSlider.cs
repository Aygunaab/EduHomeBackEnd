using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TestimonialSlider
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,MaxLength(30)]
        public string FullName { get; set; }
        [Required,MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public Position Position { get; set; }
    }
}
