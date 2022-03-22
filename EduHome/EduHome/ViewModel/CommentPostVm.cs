using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModel
{
    public class CommentPostVm
    {
        [Required,MaxLength(500)]
        public string  Description { get; set; }
        public string Subject { get; set; }
    }
}
