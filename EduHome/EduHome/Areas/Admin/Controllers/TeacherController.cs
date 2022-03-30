using EduHome.Areas.Admin.ViewModel;
using EduHome.Constants;
using EduHome.Data;
using EduHome.Models;
using EduHome.Utils;
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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
           
        }

        public async Task<IActionResult> Index()
        {
            var teacher = await _context.Teachers.Include(t => t.Position)
                .Include(t => t.Skills).Include(t => t.Social).ToListAsync();    
            
            return View(teacher);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TeacherVm model = new TeacherVm
            {
                Socials = await _context.SocialLinks.ToListAsync(),
                Skills = await _context.Skills.ToListAsync(),
                Positions=await _context.Positions.ToListAsync(),

               
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherVm model)
        {

            model.Socials = await _context.SocialLinks.ToListAsync();
            model.Skills = await _context.Skills.ToListAsync();
            model.Positions = await _context.Positions.ToListAsync();

            if (!ModelState.IsValid) return View(model);


            var position = await _context.Positions.FindAsync(model.PositionId);
            if (position == null)
            {
                ModelState.AddModelError(nameof(TeacherVm.PositionId), "Choose a valid position");
                return View(model);
            }
            var sociallink = await _context.SocialLinks.FindAsync(model.SocialId);
            if (sociallink == null)
            {
                ModelState.AddModelError(nameof(TeacherVm.SocialId), "Choose a valid position");
                return View(model);
            }
            var skills = await _context.Skills.FindAsync(model.SkillId);
            if (skills == null)
            {
                ModelState.AddModelError(nameof(TeacherVm.SkillId), "Choose a valid position");
                return View(model);
            }

            //main image
            if (!model.ImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(TeacherVm.ImageFile), "There is a problem in your file");
                return View(model);
            }



            Teacher teacher = new Teacher
            {
                Title = model.Title,
                Description = model.Description,
                Fullname=model.Fullname,
                Degree=model.Degree,
                Experiance=model.Experiance,
                Hobbies=model.Hobbies,
                Faculty=model.Faculty,
                Email=model.Email,
                Skype=model.Skype,
                Number=model.Number,
                Position=position,
                Social=sociallink,  
                Skills=model.Skills,

                Image = FileUtils.Create(FileConstants.ImagePath, model.ImageFile),

                
            };

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }
        public async Task<IActionResult> Delete(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null) return NotFound();
            FileUtils.Delete(Path.Combine(FileConstants.ImagePath, teacher.Image));

            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
