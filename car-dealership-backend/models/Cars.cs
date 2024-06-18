using System;

public enum AdvertisementState
{
	"published", "archived", "draft"
}

public enum CarState
{
	"new", "secondHand"
}

public class DealerAdministrator
{
	public int AdministratorID { get; set; }
	public string AdministratorUserName { get; set; }
	public string AdministratorPassword { get; set; }
	public string AdministratorEmail { get; set; }
	
}
public class Cars
{
	public int CarId { get; set; }
	public string CarMake { get; set; }
	public string CarModel { get; set; }
	public int CarYear { get; set; }
	public string CarColour { get; set; }
	public CarState CarState { get; set; }
	public string CarExtras { get; set; }
	public decimal CarPrice { get; set; }
	public string CarImage { get; set; }
	public AdvertisementState CarAdvertisementState { get; set; }
	public ICollection<InterestedPerson> InterestedPersons { get; set; }
}
[]
public class InterestedPerson
{
	public int UserId { get; set; }
	public string UserName { get; set; }
	public string UserSurname { get; set; }
	public string UserEmail { get; set; }
	public string UserPhoneNumber { get; set; }
	public int CarAdvertId { get; set; }
	public Cars Cars { get; set; }
}

