using Microsoft.AspNetCore.Mvc;
using RunGroop.Data;

namespace RunGroop.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: DashboardController
        public ActionResult Index()
        {
            return View();
        }

    }
}
