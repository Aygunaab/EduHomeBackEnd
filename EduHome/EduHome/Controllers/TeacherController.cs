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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            TeacherVm model = new TeacherVm
            {
                Teachers = await _context.Teachers.Include(t => t.SkillsToTeachers)
                .ThenInclude(st => st.Skills)
                .Include(t => t.SocialToTeachers)
                .ThenInclude(st => st.Social)
                .ToListAsync()

            };
         return View(model);
    }
        public IActionResult Detail(int Id)
        {


            Teacher teacher = _context.Teachers.Include(t => t.SkillsToTeachers)
                .ThenInclude(st => st.Skills)
                .Include(t => t.SocialToTeachers)
                .ThenInclude(st => st.Social)
                 .FirstOrDefault(e => e.Id == Id);


            if (teacher == null) return NotFound();






            return View(teacher);

        }
    }
}
