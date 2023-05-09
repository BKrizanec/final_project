using FinalProject.Areas.Identity.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]

    public class ServicesController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Services>>> GetServices()
        {
            if(_context.Services == null)
            {
                return NotFound();
            }
            return await _context.Services.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Services>> GetService(int id)
        {
            if (_context.Services == null)
            {
                return NotFound();
            }
            var service = await _context.Services.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            return service;
        }
    }
}
