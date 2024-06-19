using Microsoft.AspNetCore.Mvc;

namespace car_dealership_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class InterestedPersonController : ControllerBase
{
    private readonly ILogger<InterestedPersonController> _logger;

    public InterestedPersonController(ILogger<InterestedPersonController> logger)
    {
        _logger = logger;
    }
}
