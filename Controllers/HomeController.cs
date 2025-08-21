using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleRoutingDemo.Models;

namespace SimpleRoutingDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult EvenOnly(int id) => Content($"Even ID: {id} is Even Number.");
    //works only when ID is even

    public IActionResult OddOnly(int id) => Content($"Odd ID: {id} is odd Number.");
    //works only when ID is odd
    public IActionResult AnyID(int id) => Content($"Any ID: {id} is valid.");
    //normal fallback
    public IActionResult Special() => Content("special route matched dynamically");
    //action for special dynamic route
}
