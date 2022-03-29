using EduHome.Data;
using EduHome.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class SidebarDetailRightViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public SidebarDetailRightViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            SidebarDetailVm model = new SidebarDetailVm
            {
                Categories = await _context.Categories.ToListAsync(),
                Posts = await _context.Posts
                .Include(p => p.User)
                .Include(p => p.BlogComments)
                .ThenInclude(bc => bc.User).Take(3)
                .ToListAsync(),
                Tags=await _context.Tags.ToListAsync(),
                
            };
            return View(model);
        }
    }
}
