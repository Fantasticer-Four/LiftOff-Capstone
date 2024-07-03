using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Reviews.Models;
using Trips.Data;

namespace Reviews.Controllers;

public class ReviewController : Controller
{
    private readonly TripDbContext context;

    public ReviewController(TripDbContext _context)
    {
        context = _context;
    }
    public IActionResult Index()
    {
        var posts = context.Reviews.ToList();
        return View(posts);
    }
    public IActionResult Create()
    {
        List<Review> reviews = context.Reviews.ToList();
        return View(reviews);
    }
    [HttpPost]
    public async Task<IActionResult> Create(Review post)
    {
        if(ModelState.IsValid)
        {
            post.PostedDate = DateTime.Now;
            context.Reviews.Add(post);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(post);
    }
    public IActionResult Edit()
    {
        return View();
    }
    public IActionResult Delete()
    {
        return View();
    }
}

