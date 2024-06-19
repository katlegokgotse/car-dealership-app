using Microsoft.AspNetCore.Mvc;

namespace car_dealership_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{
    private readonly ILogger<CarsController> _logger;
    public CarsController(ILogger<CarsController> logger)
    {
        _logger = logger;
    }
}
