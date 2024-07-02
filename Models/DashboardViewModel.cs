namespace CarDealershipApp.Models
{
    public class DashboardViewModel
    {
        public IEnumerable<Administrator> Administrators { get; set; }
        public IEnumerable<Cars> Cars { get; set; }
    }
}
