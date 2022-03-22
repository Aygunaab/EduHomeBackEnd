using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModel
{
    public class EventVm
    {
        public Event Events{ get; set; }
        public List<Speaker> Speakers{ get; set; }
        public List<EventSpeakers> EventSpeakers { get; set; }
    }
}
