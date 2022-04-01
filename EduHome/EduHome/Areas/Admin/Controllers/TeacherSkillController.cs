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
    public class TeacherSkillController : Controller
    {

        private readonly AppDbContext _context;

        public TeacherSkillController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var skill = await _context.SkillsToTeachers.Include(ts => ts.Skills).Include(ts => ts.Teacher).ToListAsync();
            return View(skill);

        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            SkillTeacherVm model = new SkillTeacherVm
            {

                Skills = await _context.Skills.ToListAsync(),
                Teachers = await _context.Teachers.ToListAsync()
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SkillTeacherVm model)
        {
            model.Skills = await _context.Skills.ToListAsync();

            model.Teachers = await _context.Teachers.ToListAsync();

            if (!ModelState.IsValid) return View(model);

            var skill = await _context.Skills.FindAsync(model.SkillId);
            if (skill == null)
            {
                ModelState.AddModelError(nameof(SkillTeacherVm.SkillId), "Choose a valid skill");
                return View(model);
            }
            var teacher = await _context.Teachers.FindAsync(model.TeacherId);
            if (skill == null)
            {
                ModelState.AddModelError(nameof(SkillTeacherVm.TeacherId), "Choose a valid teacher");
                return View(model);
            }



            SkillsToTeacher teacherskill = new SkillsToTeacher
            {
                Skills = skill,
                Teacher = teacher,
                Progress = model.Progress,
            };

            await _context.SkillsToTeachers.AddAsync(teacherskill);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

    }
}
