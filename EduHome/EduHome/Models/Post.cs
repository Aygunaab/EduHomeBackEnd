using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Post:BaseEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
       
        [Required,MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<BlogComment> BlogComments { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
     

    }
}
