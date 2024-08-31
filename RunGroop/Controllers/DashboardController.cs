using Microsoft.AspNetCore.Mvc;
using RunGroop.Data;
using RunGroop.Interfaces;

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
            return View();
        }

    }
}
