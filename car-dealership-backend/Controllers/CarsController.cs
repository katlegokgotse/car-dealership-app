using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
namespace car_dealership_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        private readonly List<CarModels> _cars;
        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
            _cars = new List<CarModels>();
        }
        // GET all cars
        [HttpGet]
        public ActionResult<List<CarModels>> GetCars()
        {
            return _cars;
        }

        // GET car by ID
        [HttpGet("{id}")]
        public IActionResult GetCar(int id)
        {
            var car = _cars.FirstOrDefault(c => c.CarId == id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        // POST create a new car
        [HttpPost]
        public ActionResult<CarModels> CreateCar(CarModels carModel)
        {
            _cars.Add(carModel);
            return CreatedAtAction(nameof(GetCar), new { id = carModel.CarId }, carModel);
        }

        // PUT update a car
        [HttpPut("{id}")]
        public IActionResult UpdateCar(int id, CarModels carModel)
        {
            if (id != carModel.CarId)
            {
                return BadRequest();
            }

            var existingCar = _cars.FirstOrDefault(c => c.CarId == id);
            if (existingCar == null)
            {
                return NotFound();
            }

            // Update existingCar with carModel properties
            existingCar.CarModel = carModel.CarModel; // Example update

            return NoContent();
        }

        // DELETE a car
        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            var car = _cars.FirstOrDefault(c => c.CarId == id);
            if (car == null)
            {
                return NotFound();
            }
            _cars.Remove(car);
            return NoContent();
        }
    }
}
