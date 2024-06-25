using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace car_dealership_backend;

[Table("Administrators")]
public class AdministratorModels
{
    [Key]
    public int AdministratorID { get; set; }
    public string? AdministratorUserName { get; set; }
    public string? AdministratorPassword { get; set; }
    public string? AdministratorEmail { get; set; }
}
