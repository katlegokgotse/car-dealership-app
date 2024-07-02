using CarDealershipApp.Data;
using CarDealershipApp.Enums;
using CarDealershipApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CarDealershipApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _context;

        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var cars = from c in _context.Cars
                       where c.CarAdvertisementState == AdvertisementState.published
                       select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(s => s.CarMake.Contains(searchString) || s.CarModel.Contains(searchString));
            }

            return View(await cars.ToListAsync());
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
