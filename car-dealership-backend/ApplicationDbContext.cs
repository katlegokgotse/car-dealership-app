using car_dealership_backend.models;
using Microsoft.EntityFrameworkCore;

namespace car_dealership_backend
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<InterestedPersons> InterestedPersons { get; set; }
    }
}
