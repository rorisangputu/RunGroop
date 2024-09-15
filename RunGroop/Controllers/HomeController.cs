using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RunGroop.Helpers;
using RunGroop.Interfaces;
using RunGroop.Models;
using RunGroop.ViewModels;

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
        var homeViewModel = new HomeViewModel();
        try
        {
            string url = "https://ipinfo.io?token=823e1ed53c1d37";
            var info = new WebClient().DownloadString(url);
            ipInfo = JsonConvert.DeserializeObject<IPInfo>(info);
        }
        catch (System.Exception)
        {

            throw;
        }
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
