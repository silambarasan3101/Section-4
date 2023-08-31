using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MVC1._6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }


        /*public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/

        public ContentResult StudentAsString()
        {
            return Content("The name of the student is Walter Smith and he is in Grade 7.");
        }

        public ViewResult StudentAsView()
        {
            ViewData["message"] = "The name of the student is <b>Walter Smith</b> and he is in Grade 7.";
            return View();
        }

        public RedirectResult StudentAsRedirectResult()
        {
            return new RedirectResult("https://www.bing.com/search?q=walter+smith");
        }

        /*public RedirectToRouteResult StudentAsRedirectToRouteResult()
        {
            return new RedirectToRouteResult(new { Controller = "Home", action = "StudentAsView" });
        }*/


        public FileResult StudentAsFileResult()
        {
            string filePath = Server.MapPath("~/StudentData.txt");
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            string fileName = "StudentData.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public JsonResult StudentAsJSONResult()
        {
            string filePath = Server.MapPath("~/StudentData.json");
            string data = System.IO.File.ReadAllText(filePath);
            JObject json = JObject.Parse(data);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public ViewResult StudentList()
        {
            return View();
        }
    }
}