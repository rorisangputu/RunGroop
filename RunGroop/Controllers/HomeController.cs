using System.Diagnostics;
using System.Globalization;
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


    public async Task<IActionResult> Index()
    {
        var ipInfo = new IPInfo();
        var homeViewModel = new HomeViewModel();
        try
        {
            string url = "https://ipinfo.io?token=823e1ed53c1d37";
            var info = new WebClient().DownloadString(url);
            ipInfo = JsonConvert.DeserializeObject<IPInfo>(info);
            RegionInfo myRT1 = new RegionInfo(ipInfo.Country);
            ipInfo.Country = myRT1.EnglishName;
            homeViewModel.City = ipInfo.City;
            homeViewModel.State = ipInfo.Region;
            if (homeViewModel.City != null)
            {
                homeViewModel.Clubs = await clubRepo.GetClubByCity(homeViewModel.City);
            }
            else
            {
                homeViewModel.Clubs = null;
            }
            return View(homeViewModel);
        }
        catch (System.Exception)
        {
            homeViewModel.Clubs = null;
        }

        return View(homeViewModel);
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
