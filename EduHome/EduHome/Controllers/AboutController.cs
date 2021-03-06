using EduHome.Data;
using EduHome.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AboutVm model = new AboutVm
            {
                Teachers = _context.Teachers.Include(t => t.SocialToTeachers)
                .ThenInclude(st=>st.Social)
                .Include(t=>t.SkillsToTeachers)
                .ThenInclude(st=>st.Skills)
                .Take(4).ToList()
            };
            return View(model);
        }

    }
}
    

