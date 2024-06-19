using Microsoft.AspNetCore.Mvc;

namespace car_dealership_backend.Controllers;

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
    // GET all action
    [HttpGet]
    public ActionResult<List<CarModels>> GetModels()
    {
        return _cars;
    }

    // Create action
    [HttpPost]
    public ActionResult<CarModels> CreateCar(CarModels carModels)
    {
        _cars.Add(carModels);
        return CreatedAtAction(nameof(GetCars), new { id = carModels.CarId }, carModels);
    }
    // GET by Id action
    [HttpGet("{id}")]
    public IActionResult<CarModels> GetCars(int id)
    {
        var car = _cars.Find(car => car.CarId == id);
        if (car == null)
            return NotFound();
        return car;
    }
    // PUT action
    [HttpPut("{id}")]
    public IActionResult UpdateCars(int id, CarModels carModels)
    {
        //
        if (id != carModels.CarId) return BadRequest();

        var existingCar = _cars.Find(c => c.CarId == id);
        if (existingCar == null)
        {
            return NotFound();
        }

        // Update existingCar with carModel properties

        return NoContent();
    }
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult DeleteCar(int id)
    {
        //
        var car = _cars.Find(c => c.CarId == id);
        if (car == null)
        {
            return NotFound();
        }

        _cars.Remove(car);

        return NoContent();
    }
}
