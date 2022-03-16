using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TextArea
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string ShortText { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string LongText { get; set; }

    }
}
