using Microsoft.AspNetCore.Mvc;

namespace _1._41.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int age)
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index2(FormCollection form)
        {
            try
            {
                int age = Convert.ToInt16(form["age"]);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred");
                ViewBag.Error = ex.Message;
                return View("Error");
            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}