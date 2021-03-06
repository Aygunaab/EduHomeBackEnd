using EduHome.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.ViewModel
{
    public class EventSpeakerVm
    {
        public string Title { get; set; }
      
        public string Venue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [Required]
        [Display(Name = "Image")]
        public IFormFile EventPicture { get; set; }
        public string ExistingImage { get; set; }
        public string Description { get; set; }
        public int eventId { get; set; }
        public List<int> SpeakerIds { get; set; }
        public List<Event> Events { get; set; }
        public List<EventSpeakers> EventSpeakers{ get; set; }
        public List<Speaker> Speakers { get; set; }
    }
}
