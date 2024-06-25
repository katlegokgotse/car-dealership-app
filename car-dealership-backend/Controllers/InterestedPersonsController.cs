using car_dealership_backend.Data;
using Microsoft.AspNetCore.Mvc;
namespace car_dealership_backend.Controllers
{
    [Route("car_dealership_backend/InterestedPerson")]
    [ApiController]
    public class InterestedPersonController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public InterestedPersonController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetInterestedPerson()
        {
            var person = _context.interestedPeople.ToList();
            return Ok(person);
        }
    }
}
