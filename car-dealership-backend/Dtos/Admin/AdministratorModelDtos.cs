using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_dealership_backend.Dtos
{
    public class AdministratorModelDtos
    {
        public int AdministratorID { get; set; }
        public string? AdministratorUserName { get; set; }
        public string? AdministratorPassword { get; set; }
        public string? AdministratorEmail { get; set; }
    }
}