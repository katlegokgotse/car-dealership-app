using CarDealershipApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<InterestedPerson> InterestedPersons { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InterestedPerson>()
                .Property(ip => ip.UserId)
                .ValueGeneratedOnAdd();

            // Other configurations...
        }
    }
}
