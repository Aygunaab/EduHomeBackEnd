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
        public IActionResult Detail(int id, int speakerId)
        {
            Event events = _context.Events.Include(e => e.EventSpeakers)
                .ThenInclude(e=>e.Speaker).ThenInclude(s=>s.Position)
                .FirstOrDefault(e => e.Id == id);

            if (events == null) return NotFound();
            ViewBag.Related = _context.Events.Where(e => e.EventSpeakers
                .FirstOrDefault(es => es.SpeakerId == speakerId).
                SpeakerId == speakerId && e.Id != events.Id)
                .Include(e => e.EventSpeakers)
                 .ThenInclude(es => es.Speaker).ToList();


           EventDetailVm model = new EventDetailVm
            {
               Event=events
            };

            return View(model);
        }

       
    }
}
