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
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Categories
        public async Task<IActionResult> Index()
        {
              return _context.Categories != null ? 
                          View(await _context.Categories.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Categories'  is null.");
        }

        // GET: Admin/Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admin/Categories/Create
        public IActionResult Create()
        {
            ViewBag.ErrorMessage = TempData["ErrorMessage"] as string ?? "";
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Image")] Category category, IFormFile? Image)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (Image != null)
                    {
                        var imageName = Image.FileName.ToLower();
                        var saveImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/categories", imageName);
                        Directory.CreateDirectory(Path.GetDirectoryName(saveImagePath));

                        using (var stream = new FileStream(saveImagePath, FileMode.Create))
                        {
                            Image.CopyTo(stream);
                        }

                        category.Image = imageName;
                    }                    
                }
                catch(Exception ex)
                {
                    TempData["ErrorMessage"] = ex.Message;
                    return RedirectToAction(nameof(Create));
                }
                
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }

            return View(category);
        }

        // GET: Admin/Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Image")] Category category, IFormFile? newImage)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(newImage != null)
                    {
                        var newImageName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + "_" + newImage.FileName.ToLower().Replace(" ", "_");
                        var saveImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/categories", newImageName);
                        Directory.CreateDirectory(Path.GetDirectoryName(saveImagePath));

                        using (var stream = new FileStream(saveImagePath, FileMode.Create))
                        {
                            newImage.CopyTo(stream);
                        }

                        category.Image = newImageName;
                    }

                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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
            return View(category);
        }

        // GET: Admin/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Categories'  is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                if(!String.IsNullOrWhiteSpace(category.Image))
                {
                    var deleteImageFromPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/categories", category.Image);

                    if(System.IO.File.Exists(deleteImageFromPath))
                    {
                        System.IO.File.Delete(deleteImageFromPath);
                    }
                }
                _context.Categories.Remove(category);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
          return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
