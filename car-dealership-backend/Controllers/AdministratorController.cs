using Microsoft.AspNetCore.Mvc;

namespace car_dealership_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class AdministratorControllers : ControllerBase
{
    private readonly ILogger<AdministratorControllers> _logger;
    public AdministratorControllers(ILogger<AdministratorControllers> logger)
    {
        _logger = logger;
    }
}
