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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;

        public BlogController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int Id )
        {
            var UserId = _userManager.GetUserId(User);
            Post blog = _context.Posts.Include(c => c.User)
                 .Include(b => b.BlogComments)
                .ThenInclude(c => c.User)
                 .FirstOrDefault(b => b.Id == Id);


            if (blog == null) return NotFound();
            BlogDetailVm model = new BlogDetailVm
            {
                Posts = blog,
               
            };



            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> AddComment(int Id, BlogDetailVm model)
        {
            var blog= await _context.Posts.Include(c => c.User)
                .Include(c => c.BlogComments)
                .ThenInclude(c => c.User)
             
                 .FirstOrDefaultAsync(c => c.Id == Id);
            if (blog == null) return NotFound();


            if (!ModelState.IsValid)
            {
                model.Posts = blog;
                return View();
            }
            BlogComment comment = new BlogComment
            {
                Subject = model.Comment.Subject,
                Description = model.Comment.Description,
                UserId = _userManager.GetUserId(User),
                PostId=Id,
              
               
            };

            await _context.BlogComments.AddAsync(comment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Detail), new { Id });
        }
    }
}
