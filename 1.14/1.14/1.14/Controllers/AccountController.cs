using Microsoft.AspNetCore.Mvc;

namespace _1._14.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
