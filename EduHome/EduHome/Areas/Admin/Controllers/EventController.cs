using EduHome.Areas.Admin.ViewModel;
using EduHome.Constants;
using EduHome.Data;
using EduHome.Models;
using EduHome.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin,Moderator")]
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public EventController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var eventspeak = await _context.Events.Include(e => e.EventSpeakers)
                .ThenInclude(cc => cc.Speaker)
                .ToListAsync();
            return View(eventspeak);
        }
        public async Task<IActionResult>Create()
        {
            EventSpeakerVm model = new EventSpeakerVm
            {
                Events = await _context.Events.ToListAsync(),
                EventSpeakers = await _context.EventSpeakers.ToListAsync(),
                Speakers = await _context.Speakers.Include(s => s.Position).ToListAsync(),
                
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventSpeakerVm model)
        {
            
            model.EventSpeakers = await _context.EventSpeakers.ToListAsync();
            model.Speakers = await _context.Speakers.Include(s => s.Position).ToListAsync();

            if (!ModelState.IsValid) return View(model);


            //speaker
            List<EventSpeakers> speakers = new List<EventSpeakers>();
            foreach (var speakerId in model.SpeakerIds)
            {
                var speaker = await _context.Speakers.FindAsync(speakerId);
                if (speaker == null)
                {
                    ModelState.AddModelError(nameof(EventSpeakerVm.SpeakerIds), "Choose a valid speaker");
                    return View(model);
                }
                speakers.Add(new EventSpeakers { SpeakerId = speakerId });
            }

            //main image
             if (!model.MainImage.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(Post.ImageFile), "File type is unsupported, please select image");
                return View();
            }

        

            Event even = new Event
            {
                Title=model.Title,
                Description=model.Description,
               Venue=model.Venue,                           
             Image = FileUtils.Create(FileConstants.ImagePath, model.MainImage),              
               EventSpeakers= speakers,
              CreatedAt=model.CreatedAt,
              StartTime=model.StartTime,
              EndTime=model.EndTime,
               
            };

            await _context.Events.AddAsync(even);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

        public async Task<IActionResult> Delete(int id)
        {
            var events = await _context.Events.FindAsync(id);
            if (events == null) return NotFound();
            return View(events);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var events = await _context.Events.FindAsync(id);
            if (events == null) return NotFound();
            FileUtils.Delete(Path.Combine(FileConstants.ImagePath, events.Image));

            _context.Events.Remove(events);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





    }
}