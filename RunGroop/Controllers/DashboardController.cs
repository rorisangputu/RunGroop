using Microsoft.AspNetCore.Mvc;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.ViewModels;

namespace RunGroop.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository dashboardRepo;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPhotoService _photoService;

        public DashboardController(IDashboardRepository dashboardRepository,
        IHttpContextAccessor httpContextAccessor, IPhotoService photoService)
        {
            dashboardRepo = dashboardRepository;
            _httpContextAccessor = httpContextAccessor;
            _photoService = photoService;
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

        public async Task<IActionResult> EditUserProfile()
        {
            var curUserId = _httpContextAccessor.HttpContext.User.GetUserId();
            var user = await dashboardRepo.GetUserById(curUserId);
            if (user == null) return View("Error");
            var editUserViewModel = new EditUserViewModel()
            {
                Id = curUserId,
                Pace = user.Pace,
                Mileage = user.Mileage,
                ProfileImageUrl = user.ProfileImageUrl,
                City = user.City,
                State = user.State
            };
            return View(editUserViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserProfile(EditUserViewModel editUserVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit profile");
                return View("EditUserProfile", editUserVM);
            }

            var user = await dashboardRepo.GetUserByIdNoTracking(editUserVM.Id);
        }

    }
}
