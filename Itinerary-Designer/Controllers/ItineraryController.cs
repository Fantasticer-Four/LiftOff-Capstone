using System.Diagnostics;
using Itinerary_Designer.Data;
using Itinerary_Designer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Itinerary_Designer.Controllers;

public class ItineraryController : Controller
{
    private ItineraryDbContext context;

    public ItineraryController() { }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Delete()
    {
        // ViewBag.events = EventData.GetAll();

        return Redirect(/Itinerary);
    }




    // [HttpPost]
    // public IActionResult Create(CreateItineraryViewModel createItineraryViewModel)
    // {
    //     return View();
    // }
}
