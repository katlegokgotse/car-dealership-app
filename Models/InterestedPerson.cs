using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealershipApp.Models
{
    public class InterestedPerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserSurname { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhoneNumber { get; set; }

        [ForeignKey("Cars")]
        public int CarAdvertId { get; set; }
        public Cars? Cars { get; set; }
    }
}