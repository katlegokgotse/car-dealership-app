namespace car_dealership_backend.models
{
    public class InterestedPersons
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserSurname { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhoneNumber { get; set; }
        public int CarAdvertId { get; set; }
        public Cars? Cars { get; set; }
    }
}
