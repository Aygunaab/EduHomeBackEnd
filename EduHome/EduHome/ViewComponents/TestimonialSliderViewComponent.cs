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
    public class TestimonialSliderViewComponent:ViewComponent
    {

        private readonly AppDbContext _context;

        public TestimonialSliderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<TestimonialSlider> slider = await _context.TestimonialSliders.Include(t=> t.Position).ToListAsync();
            return View(slider);
        }

       
    }
}
