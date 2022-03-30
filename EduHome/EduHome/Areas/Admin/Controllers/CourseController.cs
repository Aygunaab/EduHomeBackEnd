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
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin,Moderator")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var course = await _context.Courses
                 .Include(c => c.Comments)
                .ThenInclude(c => c.User)
                .Include(c => c.CourseCategories)
                 .ThenInclude(cc => cc.Category)
                 .ToListAsync();
            return View(course);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var course = await _context.Courses
                 .Include(c => c.Comments)
                .ThenInclude(c => c.User)
                .Include(c => c.CourseCategories)
                 .ThenInclude(cc => cc.Category)
                 .FirstOrDefaultAsync(f => f.Id == id);

            if (course == null) return NotFound();

            return View(course);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            CoursePostViewModel model = new CoursePostViewModel
            {
              
                Categories = await _context.Categories.ToListAsync()
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CoursePostViewModel model)
        {
           
            model.Categories = await _context.Categories.ToListAsync();

            if (!ModelState.IsValid) return View(model);



          

            //categories
            List<CourseCategory> categories = new List<CourseCategory>();
            foreach (var categoryId in model.CategoryIds)
            {
                var category = await _context.Categories.FindAsync(categoryId);
                if (category == null)
                {
                    ModelState.AddModelError(nameof(CoursePostViewModel.CategoryIds), "Choose a valid category");
                    return View(model);
                }
                categories.Add(new CourseCategory { CategoryId = categoryId });
            }

            //main image
            if (!model.ImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(CoursePostViewModel.ImageFile), "There is a problem in your file");
                return View(model);
            }

          

            Course course = new Course
            {
               Title=model.Title,
               courtText=model.courtText,
               Description=model.Description,
               Start=model.Start,
               ClassDuration=model.ClassDuration,
               Duration=model.Duration,
               SkillLevel=model.SkillLevel,
               Language=model.Language,
               StudentsCount=model.StudentsCount,
               Assements=model.Assements,
               CoursePrice=model.CoursePrice,
                
                Image= FileUtils.Create(FileConstants.ImagePath, model.ImageFile),
               
                CourseCategories = categories
            };

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }


    }
}
