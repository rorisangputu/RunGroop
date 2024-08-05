using Microsoft.AspNetCore.Mvc;
using RunGroop.Data;

namespace RunGroop.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RaceController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            var races = _context.Races.ToList();
            return View(races);
        }
    }
}


