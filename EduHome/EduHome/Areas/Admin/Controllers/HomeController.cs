using EduHome.Data;
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
    public class HomeController : Controller
    {
       
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
          

        }
        public async Task<IActionResult> Index()
        {
            var teacher = await _context.Teachers
                 .Include(t => t.SkillsToTeachers)
                .ThenInclude(st => st.Skills)
                .Include(t => t.SocialToTeachers)
                 .ThenInclude(sT => sT.Social)
                 .ToListAsync();
            return View(teacher);
        }
    }
}
