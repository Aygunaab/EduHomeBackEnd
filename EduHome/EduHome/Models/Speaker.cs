using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required ,MaxLength(30)]
        public string FullName { get; set; }
        [Required,MaxLength(150)]
        public string ProfileImage { get; set; }
        [Required,ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public List<EventSpeakers> Speakers { get; set; }

    }
}
