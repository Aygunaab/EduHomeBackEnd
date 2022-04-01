using EduHome.Data;
using EduHome.Models;
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
    [Authorize(Roles = "Admin")]
    public class SocialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SocialController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Social> social = await _context.Socials.ToListAsync();
            return View(social);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Social social)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Socials.AddAsync(social);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Social social = await _context.Socials.FindAsync(id);
            if (social == null) return NotFound();
            return View(social);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Social social)
        {
            bool isExist = await _context.Socials.AnyAsync(c => c.Id == id);
            if (!isExist) return NotFound();

            if (social == null) return NotFound();
            if (id != social.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            _context.Socials.Update(social);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Social social = await _context.Socials.FindAsync(id);
            if (social == null) return NotFound();
            return View(social);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            Social social = await _context.Socials.FindAsync(id);
            if (social == null) return NotFound();

            _context.Socials.Remove(social);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
