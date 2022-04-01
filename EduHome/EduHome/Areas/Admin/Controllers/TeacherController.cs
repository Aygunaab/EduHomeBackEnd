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
    [Authorize(Roles = "Admin")]
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
            var teacher = await _context.Teachers
                 .Include(t=>t.SkillsToTeachers)
                .ThenInclude(st=>st.Skills)
                .Include(t=>t.SocialToTeachers)
                 .ThenInclude(sT=>sT.Social)
                 .ToListAsync();
            return View(teacher);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var teacher = await _context.Teachers
                .Include(t => t.SkillsToTeachers)
               .ThenInclude(st => st.Skills)
               .Include(t => t.SocialToTeachers)
                .ThenInclude(sT => sT.Social)
                .FirstOrDefaultAsync(f => f.Id == id);

            if (teacher== null) return NotFound();

            return View(teacher);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TeacherViewModel model = new TeacherViewModel
            {

              Socials= await _context.Socials.ToListAsync(),
               Skills= await _context.Skills.ToListAsync()
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherViewModel model)
        {
            model.Socials = await _context.Socials.ToListAsync();
            model.Skills = await _context.Skills.ToListAsync();
          

            if (!ModelState.IsValid) return View(model);





            ////Socials
            //List<SocialToTeacher> socials = new List<SocialToTeacher>();
            //foreach (var socialId in model.SocialIds)
            //{
            //    var social = await _context.Socials.FindAsync(socialId);
            //    if (social == null)
            //    {
            //        ModelState.AddModelError(nameof(TeacherViewModel.SocialIds), "Choose a valid social");
            //        return View(model);
            //    }
            //    socials.Add(new SocialToTeacher { SocialId = socialId });
            //}
            ////skill
            //List<SkillsToTeacher> skils = new List<SkillsToTeacher>();
            //foreach (var skilId in model.SkillIds)
            //{
            //    var skill = await _context.Skills.FindAsync(skilId);
            //    if (skill == null)
            //    {
            //        ModelState.AddModelError(nameof(TeacherViewModel.SkillIds), "Choose a valid skill");
            //        return View(model);
            //    }
            //    skils.Add(new SkillsToTeacher { SkillsId = skilId});
            //}

            //main image
            if (!model.ImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(CoursePostViewModel.ImageFile), "There is a problem in your file");
                return View(model);
            }



            Teacher teacher = new Teacher
            {
                Name=model.Name,
                Surname=model.Surname,
                Profession=model.Profession,
                Description=model.Description,
                Degree=model.Degree,
                Experience=model.Experience,
                Hobbies=model.Hobbies,
                Faculty=model.Faculty,
                Mail=model.Mail,
                Phone=model.Phone,
                Skype=model.Skype,
                Image = FileUtils.Create(FileConstants.ImagePath, model.ImageFile),
                //SkillsToTeachers=skils,
                //SocialToTeachers=socials,
              
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
