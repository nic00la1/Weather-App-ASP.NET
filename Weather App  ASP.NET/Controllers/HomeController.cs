using Microsoft.AspNetCore.Mvc;
using Weather_App__ASP.NET.Models;

namespace Weather_App__ASP.NET.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        ViewBag.Title = "Weather App";

        List<string>? colors = new()
            { "#6db7e6", "#e1ff8f", "#f9ca70" }; // Example colors

        List<City> cities = new()
        {
            new City()
            {
                Id = 1,
                Name = "London",
                CityUniqueCode = "LND",
                DateAndTime = DateTime.Parse("2030-01-01 8:00"),
                Temperature = 28.7,
                Color = colors[0]
            },
            new City()
            {
                Id = 2,
                Name = "New York",
                CityUniqueCode = "NYC",
                DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                Temperature = 33.5,
                Color = colors[1]
            },
            new City()
            {
                Id = 3,
                Name = "Paris",
                CityUniqueCode = "PAR",
                DateAndTime = DateTime.Parse("2030-01-01 9:00"),
                Temperature = 26.8,
                Color = colors[2]
            }
        };

        return View("Index", cities);
    }
}
