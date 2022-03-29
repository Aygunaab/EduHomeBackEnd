using EduHome.Data;
using EduHome.Models;
using EduHome.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVm model = new HomeVm
            {
                Sliders = await _context.Sliders.OrderBy(s => s.Order).Take(3).ToListAsync(),
               
            };
            return View(model);
        }
       



    }
}
