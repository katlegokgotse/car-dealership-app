using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace car_dealership_backend.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {

        }
        public DbSet<CarModels> carsModels { get; set; }
        public DbSet<InterestedPerson> interestedPeople { get; set; }
        public DbSet<AdministratorModels> administratorModels { get; set; }
    }
}