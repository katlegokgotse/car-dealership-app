using car_dealership_backend;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
[ApiController]
[Route("api/[controller]")]
public class CarController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public CarController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Cars>> GetCars()
    {
        return _context.Cars.ToList();
    }

    [HttpGet("{CarId}")]
    public ActionResult<Cars> GetCar(int id)
    {
        var car = _context.Cars.Find(id);
        if (car is null)
        {
            return NotFound();
        }
        return car;
    }

    [HttpPost]

    [HttpDelete]
    public ActionResult<Cars> DeleteCarAdvert(int id)
    {
       
    }
    //DELETE: api/Car/id
    [HttpDelete("{id}")]
    public IActionResult DeleteCarAdvert(int id)
    {

    }
}