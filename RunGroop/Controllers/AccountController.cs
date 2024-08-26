using Microsoft.AspNetCore.Mvc;

namespace RunGroop.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public ActionResult Login()
        {
            return View();
        }

    }
}
