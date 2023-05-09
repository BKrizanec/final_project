using FinalProject.Areas.Identity.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            List<ApplicationUser> users = _userManager.Users.ToList();

            return View(users);
        }

        public IActionResult Details(string? id)
        {
            if(id == null || _userManager.Users == null)
            {
                return NotFound();
            }

            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            if(user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ApplicationUser newUser, string roleId)
        {
            if(newUser == null)
            {
                return RedirectToAction(nameof(Index));
            }

            if(ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    Id = newUser.Id,
                    UserName = newUser.Email,
                    NormalizedUserName = newUser.Email.ToUpper(),
                    Email = newUser.Email,
                    NormalizedEmail = newUser.Email.ToUpper(),
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Address = newUser.Address,
                    PasswordHash = newUser.PasswordHash
                };

                var result = await _userManager.CreateAsync(user, newUser.PasswordHash);

                if(result.Succeeded)
                {
                    var role = _roleManager.FindByIdAsync(roleId).Result;

                    if (role != null)
                    {
                        await _userManager.AddToRoleAsync(user, role.Name);                        
                        return RedirectToAction(nameof(Index));
                    }
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Edit(string id)
        {            
            if (id == null) 
            {
                return RedirectToAction(nameof(Index));
            }

            var findUser = _userManager.Users.FirstOrDefault(x => x.Id == id);
            if(findUser == null) 
            {
                return RedirectToAction(nameof(Index));
            }

            return View(findUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ApplicationUser editUser, string roleId)
        {
            if (id != editUser.Id) 
            {
                return NotFound();
            }

            if(ModelState.IsValid) 
            {
                var user = await _userManager.FindByIdAsync(id);
                
                if (user == null) 
                {
                    return NotFound();
                }

                user.FirstName = editUser.FirstName;
                user.LastName = editUser.LastName;
                user.Email = editUser.Email;
                user.Address = editUser.Address;
                user.PhoneNumber = editUser.PhoneNumber;

                var role = await _roleManager.FindByIdAsync(roleId);
                if (role != null) 
                {
                    var newRole = await _userManager.AddToRoleAsync(user, role.Name);
                }

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded) 
                {
                    return RedirectToAction(nameof(Index));
                }               

                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
                
        public IActionResult Delete(string id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var findUser = _userManager.Users.FirstOrDefault(x => x.Id == id);

            if (findUser == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(findUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string Id)
        {
            if (_userManager.Users == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Lecturers'  is null.");
            }

            var user = await _userManager.FindByIdAsync(Id);

            if (user != null)
            {
                await _userManager.DeleteAsync(user);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Problem("User not found");
            }
        }
    }
}
