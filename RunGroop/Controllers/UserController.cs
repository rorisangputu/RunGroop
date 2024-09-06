using Microsoft.AspNetCore.Mvc;
using RunGroop.Interfaces;
using RunGroop.ViewModels;

namespace RunGroop.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepo;

        public UserController(IUserRepository userRepository)
        {
            userRepo = userRepository;
        }

        // GET: UserController

        public async Task<IActionResult> Index()
        {
            var users = await userRepo.GetAllUsers();
            List<UserViewModel> result = new List<UserViewModel>();
            foreach (var user in users)
            {
                var userViewModel = new UserViewModel()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Pace = user.Pace,
                    Mileage = user.Mileage
                };
                result.Add(userViewModel);
            }
            return View(result);
        }

        public async Task<IActionResult> Detail(string id)
        {
            var user = await userRepo.GetUserById(id);
            var userDetailViewModel = new UserDetailViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Pace = user.Pace,
                Mileage = user.Mileage
            };
            return View(userDetailViewModel);
        }

    }
}
