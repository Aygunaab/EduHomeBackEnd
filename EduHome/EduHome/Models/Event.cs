using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string mainImage { get; set; }
        [Required]
        public string Image { get; set; }
        public DateTime Date{ get; set; }
        
        public DateTime Time { get; set; }
        public DateTime EndTime { get; set; }
       
        [Required,MaxLength(100)]
        public string  Title { get; set; }
        [Required]
        public string Venue { get; set; }
        [Required ,MaxLength(1000)]
        public string Description { get; set; }
        public List<EventSpeakers> EventSpeakers{ get; set; }
    }
}
