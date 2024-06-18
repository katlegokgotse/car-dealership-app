using car_dealership_backend.models;
public class Cars
{
	public int CarId { get; set; }
	public string? CarMake { get; set; }
	public string? CarModel { get; set; }
	public int CarYear { get; set; }
	public string? CarColour { get; set; }
	public CarState CarState { get; set; }
	public string? CarExtras { get; set; }
	public decimal CarPrice { get; set; }
	public string? CarImage { get; set; }
	public AdvertisementState CarAdvertisementState { get; set; }
    public ICollection<InterestedPersons>? InterestedPersons { get; set; }
}