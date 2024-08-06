using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Controllers
{
    public class RaceController : Controller
    {
        private readonly IRaceRepository raceRepo;

        public RaceController(IRaceRepository raceRepository)
        {
            raceRepo = raceRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Race> races = await raceRepo.GetAll();
            return View(races);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Race race = await raceRepo.GetByIdAsync(id);
            if (race == null)
            {
                return NotFound(); // Return 404 if club not found
            }
            return View(race);
        }
    }
}


