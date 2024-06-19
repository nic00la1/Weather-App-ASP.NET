namespace Weather_App__ASP.NET.Models;

public class City
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? CityUniqueCode { get; set; }
    public DateTime DateAndTime { get; set; }
    public double Temperature { get; set; }
}
