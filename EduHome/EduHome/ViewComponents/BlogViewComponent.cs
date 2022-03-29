using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Post> posts;
            if (ViewData["Title"] == "Home Page")
            {
                posts = await _context.Posts.Include(b => b.User)
                   .Include(b => b.BlogComments)
                   .ThenInclude(c => c.User).Take(3).ToListAsync();
            }
            else
            {
                posts = await _context.Posts.Include(b => b.User)
                  .Include(b => b.BlogComments)
                  .ThenInclude(c => c.User).ToListAsync();
            }
           
            return View(posts);
        }
    }
}
