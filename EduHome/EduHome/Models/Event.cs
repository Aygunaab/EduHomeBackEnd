using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Event:BaseEntity
    {
     
        
        public string Image { get; set; }
       
        [Required,MaxLength(100)]
        public string  Title { get; set; }
        [Required]
        public string Venue { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [Required ]
        public string Description { get; set; }
        
        public List<EventSpeakers> EventSpeakers{ get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
