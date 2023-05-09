using FinalProject.Areas.Identity.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            
        }
        public IActionResult Index(bool selectAll, string? searchQuery, int servicesByCategories = 0)
        {              
            List<ServiceCategories> serviceCategories = _dbContext.ServiceCategories.ToList();            
            List<Services> services = _dbContext.Services.ToList();

            if (services != null && servicesByCategories == 0)
            {                       
                int randomEntries = Math.Min(10, services.Count);
                List<Services> randomServices = new List<Services>();

                while (randomServices.Count() < randomEntries)
                {
                    var random = new Random();
                    var randomService = services[random.Next(services.Count)];

                    if(!randomServices.Contains(randomService))
                    {
                        randomServices.Add(randomService);
                    }
                }
                services = randomServices;
            }

            if (!String.IsNullOrWhiteSpace(searchQuery))
            {
                services = services.Where(p => p.Title.ToLower().Contains(searchQuery.ToLower().Trim(' '))).ToList();
            }

            if (servicesByCategories != 0)
            {
                services = serviceCategories.Where(s => s.CategoryId == servicesByCategories).Select(s => s.Service).ToList();
            }            

            ViewBag.SelectAll = selectAll;
            if (selectAll == true)
            {
                services = _dbContext.Services.ToList();
            }

            return View(services);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}