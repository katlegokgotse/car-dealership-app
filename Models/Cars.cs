using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarDealershipApp.Enums;

namespace CarDealershipApp.Models
{
    [Table("Cars")] // Ensure this matches your table name
    public class Cars
    {


        [Key]
        public int CarId { get; set; }
        public string? CarMake { get; set; }
        public string? CarModel { get; set; }
        public int CarYear { get; set; }
        public string? CarColour { get; set; }
        public CarState CarState { get; set; }
        public string? CarExtras { get; set; }
        public decimal CarPrice { get; set; }
        public string? CarImage { get; set; }
        [NotMapped]
        public IFormFile? CarImagery { get; set; }
        public AdvertisementState CarAdvertisementState { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.Now;
        public List<InterestedPerson>? InterestedPersons { get; set; }
    }
}
