using car_dealership_backend;
using Microsoft.EntityFrameworkCore;


public class ApplicationContext() : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
    : base(options)
    {

    }
    public DbSet<CarModels> carsModels { get; set; } = null!;
    public DbSet<InterestedPerson> interestedPeople { get; set; } = null!;
    public DbSet<AdministratorModels> administratorModels { get; set; } = null!;
}