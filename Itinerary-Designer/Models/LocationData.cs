
namespace Itinerary.Models;

public class LocationData
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Category { get; set; }
    public double PricePerPerson {get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    
    public LocationData(int id, string name, string address, string category, double pricePerPerson, string description, string phone)
    {
        Id = id;
        Name = name;
        Address = address;
        Category = category;
        PricePerPerson = pricePerPerson;
        Description = description;
        Phone = phone;
    }


}