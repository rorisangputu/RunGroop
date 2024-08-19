using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.Models;
using RunGroop.ViewModels;

namespace RunGroop.Controllers
{
    public class ClubController : Controller
    {

        private readonly IClubRepository clubRepo;
        private readonly IPhotoService _photoService;

        // The constructor used for dependency injection
        public ClubController(IClubRepository clubRepository, IPhotoService photoService)
        {
            clubRepo = clubRepository;
            _photoService = photoService;
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
        public async Task<IActionResult> Create(CreateClubViewModel clubVM)
        {
            if (!ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(clubVM.Image);

                var club = new Club
                {
                    Title = clubVM.Title,
                    Description = clubVM.Description,
                    Image = result.Url.ToString()
                };
                clubRepo.Add(club);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }
            return View(clubVM);

        }
    }
}
