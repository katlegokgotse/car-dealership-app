[Route("api/[controller]")]
[ApiController]
public class InterestedPersonController : ControllerBase
{
    private readonly AppDbContext _context;
    public InterestedPersonController(AppDbContext context)
    {
        _context = context;
    }
}