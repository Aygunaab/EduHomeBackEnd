using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;
       

        public SkillController(AppDbContext context)
        {
            _context = context;
          
        }
        public async Task<IActionResult> Index()
        {
            List<Skill> skill = await _context.Skills.ToListAsync();
            return View(skill);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Skills.AddAsync(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Skill skill = await _context.Skills.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Skill skill)
        {
            bool isExist = await _context.Skills.AnyAsync(c => c.Id == id);
            if (!isExist) return NotFound();

            if (skill == null) return NotFound();
            if (id != skill.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            _context.Skills.Update(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Skill skill = await _context.Skills.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            Skill skill = await _context.Skills.FindAsync(id);
            if (skill == null) return NotFound();

            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
