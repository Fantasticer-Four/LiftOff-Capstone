using System.Diagnostics;
using Itinerary_Designer.Data;
using Itinerary_Designer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Itinerary_Designer.Controllers;

public class ItineraryController : Controller
{
    private ItineraryDbContext context;

    //   [HttpGet]
    //     public IActionResult Index()
    //     {
    //         List<Employer> Employer = context.Employers.ToList();
    //         return View(Employer);
    //     }
    public ItineraryController() { }

    public IActionResult Index()
    {
        List<Event> Events = context.Events.ToList();
        return View(Events);
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

        return Redirect("/");
    }




    // [HttpPost]
    // public IActionResult Create(CreateItineraryViewModel createItineraryViewModel)
    // {
    //     return View();
    // }
}
