using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car_dealership_backend.Enums;

namespace car_dealership_backend.Dtos.Cars
{
    public class CreateCarRequestDto
    {
        public string? CarMake { get; set; }
        public string? CarModel { get; set; }
        public int CarYear { get; set; }
        public string? CarColour { get; set; }
        public CarState CarState { get; set; }
        public string? CarExtras { get; set; }
        public decimal CarPrice { get; set; }
        public string? CarImage { get; set; }
        public AdvertisementState CarAdvertisementState { get; set; }
    }
}