using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace car_dealership_backend;

[Table("Administrator")]
public class AdministratorModels
{
    [Key]
    public int AdministratorID { get; set; }
    public string? AdministratorUserName { get; set; }
    public string? AdministratorPassword { get; set; }
    public string? AdministratorEmail { get; set; }
}
