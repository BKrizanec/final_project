using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Areas.Identity.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Services
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Services.Include(s => s.Lecturer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var services = await _context.Services
                .Include(s => s.Lecturer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (services == null)
            {
                return NotFound();
            }

            return View(services);
        }

        // GET: Admin/Services/Create
        public IActionResult Create()
        {
            ViewData["LecturerId"] = new SelectList(_context.Lecturers, "Id", "ContactEmail");
            return View();
        }

        // POST: Admin/Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Price,Description,LecturerId")] Services services, int[] categoryIds)
        {
            if (ModelState.IsValid)
            {
                _context.Add(services);
                await _context.SaveChangesAsync();

                foreach (var categoryId in categoryIds)
                {
                    ServiceCategories serviceCategory = new ServiceCategories();
                    serviceCategory.CategoryId = categoryId;
                    serviceCategory.ServiceId = services.Id;

                    _context.ServiceCategories.Add(serviceCategory);
                }
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["LecturerId"] = new SelectList(_context.Lecturers, "Id", "ContactEmail", services.LecturerId);
            return View(services);
        }

        // GET: Admin/Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var services = await _context.Services.FindAsync(id);
            if (services == null)
            {
                return NotFound();
            }
            ViewData["LecturerId"] = new SelectList(_context.Lecturers, "Id", "ContactEmail", services.LecturerId);
            return View(services);
        }

        // POST: Admin/Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Price,Description,LecturerId")] Services services)
        {
            if (id != services.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(services);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicesExists(services.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["LecturerId"] = new SelectList(_context.Lecturers, "Id", "ContactEmail", services.LecturerId);
            return View(services);
        }

        // GET: Admin/Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var services = await _context.Services
                .Include(s => s.Lecturer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (services == null)
            {
                return NotFound();
            }

            return View(services);
        }

        // POST: Admin/Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Services == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Services'  is null.");
            }
            var services = await _context.Services.FindAsync(id);
            if (services != null)
            {
                _context.Services.Remove(services);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicesExists(int id)
        {
          return (_context.Services?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
