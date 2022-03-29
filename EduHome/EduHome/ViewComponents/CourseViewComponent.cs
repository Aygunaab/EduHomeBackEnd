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
    public class CourseViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public CourseViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult >InvokeAsync()
        {

            List<Course> coursecat;
            if (ViewData["Title"] == "Home Page") {

                coursecat = await _context.Courses.Include(c => c.CourseCategories).ThenInclude(cc => cc.Category).Take(3).ToListAsync();
            }
            else
            {
                coursecat = await _context.Courses.Include(c => c.CourseCategories).ThenInclude(cc => cc.Category).ToListAsync();
            }

               
            return View(coursecat);
        }
    }
}
