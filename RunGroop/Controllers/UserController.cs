using Microsoft.AspNetCore.Mvc;

namespace RunGroop.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        [HttpGet("users")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
