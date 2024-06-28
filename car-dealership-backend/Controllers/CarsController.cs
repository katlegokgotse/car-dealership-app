using car_dealership_backend.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using car_dealership_backend.Dtos;
using car_dealership_backend.Dtos.Cars;
using car_dealership_backend.Data;

namespace car_dealership_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly List<CarModels> _cars;
        public CarsController(ApplicationDBContext context)
        {
            _context = context;
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
        [HttpPut("update/{id}")]
        public IActionResult UpdateCar(int id, UpdateCarDto updateCarDto)
        {

            var existingCar = _cars.FirstOrDefault(c => c.CarId == id);
            if (existingCar == null)
            {
                return NotFound();
            }

            // Update existingCar with carModel properties
            existingCar.CarMake = updateCarDto.CarMake;
            existingCar.CarModel = updateCarDto.CarModel;
            existingCar.CarYear = updateCarDto.CarYear;
            existingCar.CarColour = updateCarDto.CarColour;
            existingCar.CarState = updateCarDto.CarState;
            existingCar.CarExtras = updateCarDto.CarExtras;
            existingCar.CarPrice = updateCarDto.CarPrice;
            existingCar.CarImage = updateCarDto.CarImage;
            existingCar.CarAdvertisementState = updateCarDto.CarAdvertisementState;

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
        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateCarRequestDto carRequestDto)
        {
            var carModel = carRequestDto.ToCreateCarFromCreateDto();
            _context.carsModels.Add(carModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCarById), new { id = carModel.CarId }, carModel.CarFromDto());
        }
        [HttpGet("details/{id}")]
        private IActionResult GetCarById([FromRoute] int id)
        {
            var cars = _context.carsModels.Find(id);
            if (cars == null)
            {
                return NotFound();
            }
            return Ok(cars.CarFromDto());
        }
    }
}
