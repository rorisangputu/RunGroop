using Microsoft.AspNetCore.Mvc;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.ViewModels;

namespace RunGroop.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository dashboardRepo;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            dashboardRepo = dashboardRepository;
        }


        // GET: DashboardController
        public async Task<IActionResult> Index()
        {
            var userRaces = await dashboardRepo.GetAllUserRaces();
            var userClubs = await dashboardRepo.GetAllUserClubs();
            var dashboardVM = new DashboardViewModel()
            {
                Races = userRaces,
                Clubs = userClubs
            };
            return View(dashboardVM);
        }

    }
}
