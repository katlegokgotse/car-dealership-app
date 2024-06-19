using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace car_dealership_backend;

[Table("InterestedPerson")]
public class InterestedPerson
{
    [Key]
    public int UserId { get; set; }
    public string? UserName { get; set; }
    public string? UserSurname { get; set; }
    public string? UserEmail { get; set; }
    public string? UserPhoneNumber { get; set; }
    public int CarAdvertId { get; set; }
    public CarModels? Cars { get; set; }
}
