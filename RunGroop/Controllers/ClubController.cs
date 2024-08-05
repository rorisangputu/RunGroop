using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroop.Data;

namespace RunGroop.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        // The constructor used for dependency injection
        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList(); // Fetching clubs from db and listing
            return View(clubs);
        }

        public IActionResult Detail(int id)
        {
            var club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            if (club == null)
            {
                return NotFound(); // Return 404 if club not found
            }
            return View(club);
        }

        // Additional actions for Create, Edit, Delete, etc.
    }
}
