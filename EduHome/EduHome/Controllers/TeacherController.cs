using EduHome.Data;
using EduHome.Models;
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

        public async Task< IActionResult> Index()
        {
            List<Teacher> teachers = await _context.Teachers.Include(t => t.Social).Include(t => t.Position).ToListAsync();
            return View(teachers);
        }
        public IActionResult Detail(int Id)
        {

            Teacher teacher = _context.Teachers
                 .Include(t => t.Social)
                .Include(t=>t.Position)
                 .Include(t => t.Skills)
                 .FirstOrDefault(e => e.Id == Id);


            if (teacher == null) return NotFound();


           

           

            return View(teacher);

        }
    }
}
