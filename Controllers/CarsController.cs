using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarDealershipApp.Data;
using CarDealershipApp.Models;
using NuGet.Protocol.Plugins;
using System.Runtime.ConstrainedExecution;

namespace CarDealershipApp.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CarsController(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> TopFour()
        {
            var newestCars = await _context.Cars
                .OrderByDescending(c => c.DatePosted)
                .Take(4)
                .ToListAsync();
            return View(newestCars);
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (cars == null)
            {
                return NotFound();
            }

            return View(cars);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("CarId,CarMake,CarModel,CarYear,CarColour,CarState,CarExtras,CarPrice,CarImage, CarImagery, CarAdvertisementState")] Cars cars)
        {
            if (ModelState.IsValid)
            {
                if (cars.CarImagery != null)
                {
                    var fileName = Path.GetFileName(cars.CarImagery.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await cars.CarImagery.CopyToAsync(stream);
                    }
                    cars.CarImage = "/images/" + fileName;
                }
                _context.Add(cars);
                await _context.SaveChangesAsync();
                Console.WriteLine($"Car image saved to: {cars.CarImage}");
                return RedirectToAction(nameof(Index));
            }

            return View(cars);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars.FindAsync(id);
            if (cars == null)
            {
                return NotFound();
            }
            return View(cars);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarId,CarMake,CarModel,CarYear,CarColour,CarState,CarExtras,CarPrice,CarImage,CarAdvertisementState")] Cars cars)
        {
            if (id != cars.CarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cars);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarsExists(cars.CarId))
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
            return View(cars);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cars = await _context.Cars
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (cars == null)
            {
                return NotFound();
            }

            return View(cars);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cars = await _context.Cars.FindAsync(id);
            if (cars != null)
            {
                _context.Cars.Remove(cars);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarsExists(int id)
        {
            return _context.Cars.Any(e => e.CarId == id);
        }

        public async Task<IActionResult> MoreInfo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            ViewBag.CarMake = car.CarMake;
            ViewBag.CarModel = car.CarModel;
            ViewBag.CarYear = car.CarYear;
            ViewBag.CarColour = car.CarColour;
            ViewBag.CarState = car.CarState;
            ViewBag.CarExtras = car.CarExtras;
            ViewBag.CarPrice = car.CarPrice;

            return View(new ContactInfoViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MoreInfo(int id, ContactInfoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var interestedPerson = new InterestedPerson
                {
                    CarAdvertId = id,
                    UserName = model.Name,
                    UserSurname = model.Surname,
                    UserEmail = model.Email,
                    UserPhoneNumber = model.Phone
                };

                _context.InterestedPersons.Add(interestedPerson);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Details), new { id });
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            ViewBag.CarMake = car.CarMake;
            ViewBag.CarModel = car.CarModel;
            ViewBag.CarYear = car.CarYear;
            ViewBag.CarColour = car.CarColour;
            ViewBag.CarState = car.CarState;
            ViewBag.CarExtras = car.CarExtras;
            ViewBag.CarPrice = car.CarPrice;

            return View(model);
        }

    }
}
