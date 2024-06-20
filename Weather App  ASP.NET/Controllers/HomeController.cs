using Microsoft.AspNetCore.Mvc;
using Weather_App__ASP.NET.Models;

namespace Weather_App__ASP.NET.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        ViewBag.Title = "Weather App";

        List<City> cities = new()
        {
            new City()
            {
                Id = 1,
                Name = "London",
                CityUniqueCode = "LND",
                DateAndTime = DateTime.Parse("2030-01-01 8:00"),
                Temperature = 0.5
            },
            new City()
            {
                Id = 2,
                Name = "New York",
                CityUniqueCode = "NYC",
                DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                Temperature = 15.6
            },
            new City()
            {
                Id = 3,
                Name = "Paris",
                CityUniqueCode = "PAR",
                DateAndTime = DateTime.Parse("2030-01-01 9:00"),
                Temperature = 27.7
            }
        };

        return View("Index", cities);
    }

    [Route("/weather/{cityCode}")]
    public IActionResult Details(string? cityCode)
    {
        @ViewBag.Title = "Weather App - Details";

        if (cityCode == null) return NotFound("City code can't be null");

        List<City> cities = new()
        {
            new City()
            {
                Id = 1,
                Name = "London",
                CityUniqueCode = "LND",
                DateAndTime = DateTime.Parse("2030-01-01 8:00"),
                Temperature = 0.5
            },
            new City()
            {
                Id = 2,
                Name = "New York",
                CityUniqueCode = "NYC",
                DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                Temperature = 15.6
            },
            new City()
            {
                Id = 3,
                Name = "Paris",
                CityUniqueCode = "PAR",
                DateAndTime = DateTime.Parse("2030-01-01 9:00"),
                Temperature = 27.7
            }
        };

        City? matchingCodeCity =
            cities.FirstOrDefault(c => c.CityUniqueCode == cityCode);

        return View(matchingCodeCity); // Views/Home/Details.cshtml
    }
}
