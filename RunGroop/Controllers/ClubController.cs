using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Controllers
{
    public class ClubController : Controller
    {

        private readonly IClubRepository clubRepo;

        // The constructor used for dependency injection
        public ClubController(IClubRepository clubRepository)
        {
            clubRepo = clubRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Club> clubs = await clubRepo.GetAll(); // Fetching clubs from db and listing
            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Club club = await clubRepo.GetByIdAsync(id);
            if (club == null)
            {
                return NotFound(); // Return 404 if club not found
            }
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }

        // Additional actions for Create, Edit, Delete, etc.
        [HttpPost]
        public async Task<IActionResult> Create(Club club)
        {
            if (!ModelState.IsValid)
            {
                return View(club);
            }
            clubRepo.Add(club);
            return RedirectToAction("Index");
        }
    }
}
