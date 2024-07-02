using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealershipApp.Models
{
    [Table("Administrators")]
    public class Administrator
    {
        [Key]
        public int AdministratorID { get; set; }
        public string? AdministratorUserName { get; set; }
        public string? AdministratorPassword { get; set; }
        public string? AdministratorEmail { get; set; }
    }
}
