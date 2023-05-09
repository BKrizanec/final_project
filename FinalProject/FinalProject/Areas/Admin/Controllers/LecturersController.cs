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
    public class LecturersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LecturersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Lecturers
        public async Task<IActionResult> Index()
        {
              return _context.Lecturers != null ? 
                          View(await _context.Lecturers.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Lecturers'  is null.");
        }

        // GET: Admin/Lecturers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lecturers == null)
            {
                return NotFound();
            }

            var lecturer = await _context.Lecturers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lecturer == null)
            {
                return NotFound();
            }

            return View(lecturer);
        }

        // GET: Admin/Lecturers/Create
        public IActionResult Create()
        {
            ViewBag.ErrorMessage = TempData["ErrorMessage"] as string ?? "";
            return View();
        }

        // POST: Admin/Lecturers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Bio,ContactEmail,Image")] Lecturer lecturer, IFormFile? Image)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if(Image != null)
                    {
                        var imageName = Image.FileName.ToLower();
                        var saveImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/lecturers", imageName);
                        Directory.CreateDirectory(Path.GetDirectoryName(saveImagePath));

                        using (var stream = new FileStream(saveImagePath, FileMode.Create))
                        {
                            Image.CopyTo(stream);
                        }

                        lecturer.Image = imageName;
                    }
                }
                catch(Exception ex)
                {
                    TempData["ErrorMessage"] = ex.Message;
                    return RedirectToAction(nameof(Create));
                }

                _context.Add(lecturer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(lecturer);
        }

        // GET: Admin/Lecturers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lecturers == null)
            {
                return NotFound();
            }

            var lecturer = await _context.Lecturers.FindAsync(id);
            if (lecturer == null)
            {
                return NotFound();
            }
            return View(lecturer);
        }

        // POST: Admin/Lecturers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Bio,ContactEmail,Image")] Lecturer lecturer, IFormFile? newImage)
        {
            if (id != lecturer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (newImage != null)
                    {
                        var newImageName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + "_" + newImage.FileName.ToLower().Replace(" ", "_");
                        var saveImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/lecturers", newImageName);
                        Directory.CreateDirectory(Path.GetDirectoryName(saveImagePath));

                        using (var stream = new FileStream(saveImagePath, FileMode.Create))
                        {
                            newImage.CopyTo(stream);
                        }

                        lecturer.Image = newImageName;
                    }

                    _context.Update(lecturer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LecturerExists(lecturer.Id))
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
            return View(lecturer);
        }

        // GET: Admin/Lecturers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lecturers == null)
            {
                return NotFound();
            }

            var lecturer = await _context.Lecturers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lecturer == null)
            {
                return NotFound();
            }

            return View(lecturer);
        }

        // POST: Admin/Lecturers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lecturers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Lecturers'  is null.");
            }
            var lecturer = await _context.Lecturers.FindAsync(id);
            if (lecturer != null)
            {
                if (!String.IsNullOrWhiteSpace(lecturer.Image))
                {
                    var deleteImageFromPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/categories", lecturer.Image);

                    if (System.IO.File.Exists(deleteImageFromPath))
                    {
                        System.IO.File.Delete(deleteImageFromPath);
                    }
                }
                _context.Lecturers.Remove(lecturer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LecturerExists(int id)
        {
          return (_context.Lecturers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
