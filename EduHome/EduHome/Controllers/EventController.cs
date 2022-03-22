using EduHome.Data;
using EduHome.Models;
using EduHome.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public async Task< IActionResult> Index()
        {

            var eventspeak = await _context.Events.Include(e => e.EventSpeakers).ThenInclude(cc => cc.Speaker).ToListAsync();


            return View(eventspeak);
        }
        public IActionResult Detail(int Id, int SpeakerId)
        {

            Event even = _context.Events
                 .Include(e => e.EventSpeakers)
                 .ThenInclude(es => es.Speaker)
                 .FirstOrDefault(e => e.Id == Id);


            if (even == null) return NotFound();


            ViewBag.Related = _context.Events.Where(e => e.EventSpeakers
                .FirstOrDefault(es => es.SpeakerId == SpeakerId).
                SpeakerId == SpeakerId && e.Id != even.Id)
                .Include(e => e.EventSpeakers)
                 .ThenInclude(es => es.Speaker).ToList();

            EventVm model = new EventVm
            {


                Events = even,
                Speakers = _context.Speakers.Include(s => s.Position).ToList(),
                EventSpeakers = _context.EventSpeakers.ToList()

            };

            return View(model);

        }
    }
}
