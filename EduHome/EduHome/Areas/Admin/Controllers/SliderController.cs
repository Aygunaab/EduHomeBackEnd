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
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
   
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult >Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            if (!slider.ImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File type is unsupported, please select image");
                return View();
            }
           

      
            slider.BackgroundImage = FileUtils.Create(FileConstants.ImagePath, slider.ImageFile);
          

            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task< IActionResult> Delete(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            FileUtils.Delete(Path.Combine(FileConstants.ImagePath, slider.BackgroundImage));
           
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id,Slider slider)
        {
            var dbslider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            if (id != slider.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.Delete(Path.Combine(FileConstants.ImagePath, dbslider.BackgroundImage));
            dbslider.BackgroundImage = FileUtils.Create(FileConstants.ImagePath, slider.ImageFile);
            dbslider.Title = slider.Title;
            dbslider.Description = slider.Description;
            dbslider.Order = slider.Order;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
