using System;
using System.Web;
[ApiController]
[Route("api/[controller]")]
public class CarController : ControllerBase
{
    private readonly AppDbContext _context;
    public CarController(AppDbContext context)
    {
        _context = context;
    }
    public
}