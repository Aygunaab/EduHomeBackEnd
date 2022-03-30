using EduHome.Areas.Admin.ViewModel;
using EduHome.Constants;
using EduHome.Data;
using EduHome.Models;
using EduHome.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin,Moderator")]
    public class BlogController : Controller
    {
   
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<User> _userManager;

        public BlogController(AppDbContext context, IWebHostEnvironment env, UserManager<User> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            var blog = await _context.Posts
                .Include(b=>b.User)
                .Include(b=>b.BlogComments)
                .ThenInclude(bc=>bc.User)
                .ToListAsync();
            return View(blog);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post post)
        {
            if (!ModelState.IsValid) return View();
            post.UserId = _userManager.GetUserId(User);
            if (!post.ImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(Post.ImageFile), "File type is unsupported, please select image");
                return View();
            }



            post.Image = FileUtils.Create(FileConstants.ImagePath, post.ImageFile);


            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null) return NotFound();
            return View(post);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var blog = await _context.Posts.FindAsync(id);
            if (blog == null) return NotFound();
            FileUtils.Delete(Path.Combine(FileConstants.ImagePath, blog.Image));

            _context.Posts.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var blog = await _context.Posts.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Post post)
        {
            var dbpost = await _context.Posts.FindAsync(id);
            if (post == null) return NotFound();
            if (id != post.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.Delete(Path.Combine(FileConstants.ImagePath, dbpost.Image));
            dbpost.Image = FileUtils.Create(FileConstants.ImagePath, post.ImageFile);
            dbpost.Title = post.Title;
            dbpost.Description = post.Description;
          

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
