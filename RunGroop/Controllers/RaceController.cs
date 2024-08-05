using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Detail(int id)
        {
            var race = _context.Races.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            if (race == null)
            {
                return NotFound(); // Return 404 if club not found
            }
            return View(race);
        }
    }
}


