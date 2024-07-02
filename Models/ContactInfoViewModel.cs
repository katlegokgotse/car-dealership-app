using System.ComponentModel.DataAnnotations;

namespace CarDealershipApp.Models
{
    public class ContactInfoViewModel
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public string? Surname { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public string? Phone { get; set; }
    }
}
