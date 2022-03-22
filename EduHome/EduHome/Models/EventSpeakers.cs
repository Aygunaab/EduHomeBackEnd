using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class EventSpeakers
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int SpeakerId { get; set; }
        public Event Event { get; set; }
        public Speaker Speaker{ get; set; }

    }
}
