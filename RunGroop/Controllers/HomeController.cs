using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RunGroop.Helpers;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IClubRepository clubRepo;

    public HomeController(ILogger<HomeController> logger, IClubRepository clubRepository)
    {
        _logger = logger;
        clubRepo = clubRepository;
    }


    public IActionResult Index()
    {
        var ipInfo = new IPInfo();
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
}
