using EduHome.Areas.Admin.ViewModel;
using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeacherSocialController : Controller
    {


        private readonly AppDbContext _context;
       

        public TeacherSocialController(AppDbContext context)
        {
            _context = context;
            
        }
        public async Task<IActionResult> Index()
        {
            var social = await _context.SocialToTeachers.Include(ts=>ts.Social).Include(ts=>ts.Teacher).ToListAsync();
            return View(social);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            SocialTeacherVm model = new SocialTeacherVm
            {

                Socials = await _context.Socials.ToListAsync(),
                Teachers = await _context.Teachers.ToListAsync()
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SocialTeacherVm model)
        {
            model.Socials = await _context.Socials.ToListAsync();

            model.Teachers = await _context.Teachers.ToListAsync();

            if (!ModelState.IsValid) return View(model);

            var social = await _context.Socials.FindAsync(model.SocialId);
            if (social == null)
            {
                ModelState.AddModelError(nameof(SocialTeacherVm.SocialId), "Choose a valid social");
                return View(model);
            }
            var teacher = await _context.Teachers.FindAsync(model.TeacherId);
            if (social == null)
            {
                ModelState.AddModelError(nameof(SocialTeacherVm.TeacherId), "Choose a valid social");
                return View(model);
            }



            SocialToTeacher teachersocial = new SocialToTeacher
            {
               Social=social,
               Teacher=teacher,
               Link=model.Link,
            };

            await _context.SocialToTeachers.AddAsync(teachersocial);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }


    }
}

