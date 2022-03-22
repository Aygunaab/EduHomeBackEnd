using EduHome.Data;
using EduHome.Models;
using EduHome.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;

        public CourseController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            var coursecat = await _context.Courses.Include(c => c.CourseCategories).ThenInclude(cc => cc.Category).ToListAsync();

           
            return View(coursecat);
        }
       public IActionResult Detail(int Id,int CategoryId)
        {

            Course course = _context.Courses.Include(c=>c.Feature)
                 .Include(c => c.Comments)
                .ThenInclude(c => c.User)
                .Include(c => c.CourseCategories)
                 .ThenInclude(cc => cc.Category)
                 .FirstOrDefault(c => c.Id == Id);


            if (course == null) return NotFound();
            

            ViewBag.Related = _context.Courses.Where(c => c.CourseCategories
                .FirstOrDefault(cc => cc.CategoryId == CategoryId).
                CategoryId == CategoryId && c.Id != course.Id)
                .Include(c => c.CourseCategories)
                 .ThenInclude(cc => cc.Category).ToList();

            CourseDetailVm model = new CourseDetailVm
            {
               
           
                Courses =course,
                Categorys = _context.Categories.ToList(),
               

            };

            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
       public async Task<IActionResult>AddComment(int Id,CourseDetailVm model)
        {
            var course =await _context.Courses.Include(c => c.Feature)
                .Include(c=>c.Comments)
                .ThenInclude(c=>c.User)
                 .Include(c => c.CourseCategories)
                 .ThenInclude(cc => cc.Category)
                 .FirstOrDefaultAsync(c => c.Id == Id);
            if (course == null) return NotFound();
           

            if (!ModelState.IsValid)
            {
                model.Courses = course;
                return View();
            }
            Comment comment = new Comment
            {
                Subject = model.Comment.Subject,
                Description = model.Comment.Description,
                UserId = _userManager.GetUserId(User),
                CourseId = Id
            };

            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Detail), new { Id });
        }
    }
}
